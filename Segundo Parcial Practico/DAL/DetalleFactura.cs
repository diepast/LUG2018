using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DetalleFactura : BE.ICrud<BE.DetalleFactura>
    {
        string cconnstr = @"Data Source=('C:\Segundo Parcial Practico\Segundo Parcial Practico\')\servidor;Initial Catalog=FacturacionLUG;Integrated Security=True";

        private static DetalleFactura _instancia = null;

        private DetalleFactura()
        { }

        public static DetalleFactura GetInstance()
        {
            if (_instancia==null)
            {
                _instancia = new DetalleFactura();
            }

            return _instancia;
        }


        public System.Data.DataTable SelectAlldt()
        {
            throw new NotImplementedException();
        }

        public int Add(BE.DetalleFactura objAlta)
        {
            try
            {
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@intIdProducto", objAlta.Producto.Id));
                p.Add(new SqlParameter("@intIdFactura", objAlta.Id));
                p.Add(new SqlParameter("@intCantidad", objAlta.Cantidad));
                return Helper.sqlHelper.GetInstance(cconnstr).ExecuteScalarint("DetalleFacturaInsert", p);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(BE.DetalleFactura objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.DetalleFactura objUpdate)
        {
            throw new NotImplementedException();
        }

        public BE.DetalleFactura SelectById(BE.DetalleFactura objSelect)
        {
            throw new NotImplementedException();
        }

        public List<BE.DetalleFactura> SelectAll()
        {
            throw new NotImplementedException();
        }

    }
}
