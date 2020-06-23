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
    public partial class Facturar : Form
    {
        BE.Factura factura;
        BE.DetalleFactura listadetallefactura;
        List<BE.Producto> listaproductos;
        DataTable dtFact;
        public Facturar()
        {
            InitializeComponent();
            factura=new BE.Factura();
            listadetallefactura=new BE.DetalleFactura();
            listaproductos=new List<BE.Producto>();
            ConfigurarGrilla(ref dgvFactura);
            ConfigurarGrilla(ref dgvProductos);
            FacturaDetalle();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 21; i++)
            {
                cmbCantidad.Items.Add(i);    
            }
            cmbCantidad.SelectedItem = 1;

            BLL.Producto p1 =new BLL.Producto();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = p1.SelectAlldt();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            BLL.Producto p1 = new BLL.Producto();
            BE.DetalleFactura detallefactura = new BE.DetalleFactura();
            
            try
            {
                if (txtid.Text=="")
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }
                else { 

                    for (int i = 0; i < dgvProductos.SelectedRows.Count; i++)
                    {
                        foreach (DataRow item in p1.SelectAlldt().Rows)
                        {
                            if ((int)(dgvProductos.SelectedRows[i].Cells[0].Value) == int.Parse(item[0].ToString()))
                            {
                                DataRow dr=dtFact.NewRow();

                                dr[0] = int.Parse(item[0].ToString());// int.Parse(dgvProductos.SelectedRows[i].Cells[0].Value.ToString());
                                dr[1] = item[1].ToString();// dgvProductos.SelectedRows[i].Cells[1].Value.ToString();
                                dr[2] = decimal.Parse(item[2].ToString());// decimal.Parse(dgvProductos.SelectedRows[i].Cells[2].Value.ToString());
                                dr[3] = int.Parse(item[3].ToString());// int.Parse(dgvProductos.SelectedRows[i].Cells[3].Value.ToString());
                                dr[4] = int.Parse(cmbCantidad.SelectedItem.ToString());
                                dr[5] = int.Parse(cmbCantidad.SelectedItem.ToString()) * decimal.Parse(item[2].ToString());
                                //factura.setDetalle(detallefactura);
                                foreach (DataRow aux in dtFact.Rows)
                                {
                                    if (int.Parse(dr[0].ToString())==int.Parse(aux[0].ToString()))
                                    {

                                        //Sumo cantidad
                                        dr[4] = int.Parse(aux[4].ToString()) +int.Parse(dr[4].ToString());
                                        dr[5] = int.Parse(dr[4].ToString()) * decimal.Parse(item[2].ToString());
                                        dtFact.Rows.Remove(aux);
                                        break;
                                    }
                                }
                                dtFact.Rows.Add(dr);
                                Limpiarcontroles();
                                break;
                            }
                        
                        }
                    
                    }
                    ActualizarGrilla();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ActualizarGrilla()
        {
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = dtFact;
                //factura.getDetalle();
        }

        private void Limpiarcontroles()
        {
            txtid.Text="";
            txtdesc.Text = "";
            txtstock.Text = "";
            txtprecio.Text = "";
            cmbCantidad.SelectedItem = 1;
            txtdesc.Focus();
        }


        private void btnAgregarCLiente_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (Persona item in bl.GetPersonas())
                //{
                //    if ((dgvClientes.SelectedRows[0].Cells[0].Value).ToString() == item.DNI.ToString())
                //    {
                //        p1.persona = item;
                //        break;

                //    }

                //}                

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (!(dgvProductos.SelectedRows.Count == 0))
                {
                    if (!(dgvProductos.SelectedCells[1].Value.ToString() == ""))
                    {
                        //id desc precio stock
                        txtid.Text = dgvProductos.SelectedCells[0].Value.ToString();
                        txtdesc.Text = dgvProductos.SelectedCells[1].Value.ToString();
                        txtprecio.Text = dgvProductos.SelectedCells[2].Value.ToString();
                        txtstock.Text = dgvProductos.SelectedCells[3].Value.ToString();
                    }
                }
                else
                {

                }
            }
            catch(Exception ex)
            { 
                throw ex;
            }
        }

        private void ConfigurarGrilla(ref DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = true;
        }

        private void FacturaDetalle()
        {
            dtFact = new DataTable("FacturaDetalle");
            DataColumn pk = new DataColumn("ID");
            dtFact.Columns.Add(pk);
            dtFact.Columns.Add("Descripcion", typeof(string));
            dtFact.Columns.Add("Precio", typeof(string));
            dtFact.Columns.Add("Stock", typeof(int));
            dtFact.Columns.Add("Cantidad", typeof(int));
            dtFact.Columns.Add("Total", typeof(decimal));
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvProductos.SelectedRows.Count; i++)
            {
                foreach (DataRow aux in dtFact.Rows)
                {
                    if ( int.Parse(dgvFactura.SelectedRows[i].Cells[0].Value.ToString()) == int.Parse(aux[0].ToString()))
                    {
                        dtFact.Rows.Remove(aux);
                        break;
                    }
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (ValidarStock())
            {
                MessageBox.Show("Por favor verifique stock disponible");
            }
            else
            {
                Venta v = new Venta(dtFact);
                v.ShowDialog();
            }
        }

        private bool ValidarStock()
        {
            bool ret = false;
            foreach (DataRow item in dtFact.Rows)
            {
                if (int.Parse(item[4].ToString()) > int.Parse(item[3].ToString()))
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
