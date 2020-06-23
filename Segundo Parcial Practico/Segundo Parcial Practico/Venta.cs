using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Segundo_Parcial_Practico
{
    public partial class Venta : Form
    {
        DataTable _dtfact;
        public Venta(DataTable dtfact)
        {
            InitializeComponent();
            this._dtfact = dtfact;
            ConfigurarGrilla();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            BLL.Cliente c1 = new BLL.Cliente();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = c1.SelectAlldt();
            BLL.Factura f1=new BLL.Factura();
            int maxid=int.Parse(f1.GetMaxId().ToString());
            if (maxid.Equals(null))
            {
                txtidfactura.Text = "1";
            }
            else if (maxid == 0)
            {
                txtidfactura.Text = (maxid + 1).ToString();
            }
            else
            {
                txtidfactura.Text = maxid.ToString();
            }
            decimal total = 0;

            foreach (DataRow aux in _dtfact.Rows)
            {
                total = total + decimal.Parse(aux[5].ToString());
            }
            txttotal.Text = total.ToString();

        }

        private void ConfigurarGrilla()
        {
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = true;
        }

        private void CargarVenta()
        {

            BLL.Factura f1 = new BLL.Factura();
            BE.Factura f = new BE.Factura();
            f.Id = int.Parse(txtidfactura.Text);
            f.Fecha = dateTimePicker1.Value.Date;
            BE.Cliente c1 = new BE.Cliente();
            c1.Id = int.Parse(txtidcliente.Text);
            c1.Nombre = txtnombre.Text;
            c1.Apellido = txtapellido.Text;
            c1.Direccion = txtdireccion.Text;
            c1.Telefono = txttelefono.Text;
            f.Cliente = c1;
            //            List<BE.DetalleFactura> listafd = new List<BE.DetalleFactura>(); 
            BE.DetalleFactura df;
            //          List<BE.Producto> listaprod =new List<BE.Producto>();
            BE.Producto p1;
            f1.Add(f);
            txtidfactura.Text= f1.GetMaxId().ToString();
            foreach (DataRow aux in _dtfact.Rows)
            {
                p1 = new BE.Producto();
                df = new BE.DetalleFactura();
                p1.Id = int.Parse(aux[0].ToString());
                p1.Descripcion = aux[1].ToString();
                p1.Precio = decimal.Parse(aux[2].ToString());
                p1.Stock = int.Parse(aux[3].ToString());

                df.Id =int.Parse(txtidfactura.Text);
                df.Producto = p1;
                df.Cantidad = int.Parse(aux[4].ToString());
                f.setDetalle(df);
                p1 = null;
                df = null;
            }
 
            BLL.DetalleFactura fd1 = new BLL.DetalleFactura();
             foreach (BE.DetalleFactura item in f.getDetalle())
            {
                fd1.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarVenta();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (!(dgvClientes.SelectedRows.Count == 0))
                {
                    if (!(dgvClientes.SelectedCells[1].Value.ToString() == ""))
                    {
                        txtidcliente.Text = dgvClientes.SelectedCells[0].Value.ToString();
                        txtnombre.Text = dgvClientes.SelectedCells[1].Value.ToString();
                        txtapellido.Text = dgvClientes.SelectedCells[2].Value.ToString();
                        txtdireccion.Text = dgvClientes.SelectedCells[3].Value.ToString();
                        txttelefono.Text= dgvClientes.SelectedCells[4].Value.ToString();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
