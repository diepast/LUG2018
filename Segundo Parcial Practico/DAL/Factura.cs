using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Factura : BE.IFactura<BE.Factura,BE.DetalleFactura>,BE.ICrud<BE.Factura>
    {
        string cconnstr = @"Data Source=('C:\Segundo Parcial Practico\Segundo Parcial Practico\')\servidor;Initial Catalog=FacturacionLUG;Integrated Security=True";

        private static Factura _instancia = null;

        private Factura()
        { }

        public static Factura GetInstance()
        {
            if (_instancia==null)
            {
                _instancia = new Factura();
            }

            return _instancia;
        }


        public int GetMaxId()
        {
            try
            {
                string SP = "sp_get_max_id";
                return int.Parse(Helper.sqlHelper.GetInstance(cconnstr).ExecuteScalar(SP).ToString());

            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public decimal GetTotal(BE.Factura objdet)
        {
            throw new NotImplementedException();
        }

        public decimal GetSubtotal(BE.Factura objSub)
        {
            throw new NotImplementedException();
        }

        public int CantidadProductos(BE.Factura objSub)
        {
            throw new NotImplementedException();
        }

        public List<BE.DetalleFactura> GetDetails(BE.Factura objDet)
        {
            throw new NotImplementedException();
        }

        public bool AddLine(BE.Factura objFact, BE.DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }

        public int Add(BE.Factura objAlta)
        {
            try
            {
                List<SqlParameter> p=new List<SqlParameter>();
                p.Add(new SqlParameter("@datFecha", objAlta.Fecha));
                p.Add(new SqlParameter("@intIdCliente", objAlta.Cliente.Id));
                return Helper.sqlHelper.GetInstance(cconnstr).ExecuteScalarint("FacturaInsert", p);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public bool Delete(BE.Factura objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Factura objUpdate)
        {
            throw new NotImplementedException();
        }

        public BE.Factura SelectById(BE.Factura objSelect)
        {
            throw new NotImplementedException();
        }

        public List<BE.Factura> SelectAll()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable SelectAlldt()
        {
            throw new NotImplementedException();
        }
    }
}
