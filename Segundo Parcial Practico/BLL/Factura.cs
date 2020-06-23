using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Factura : BE.IFactura<BE.Factura,BE.DetalleFactura>,BE.ICrud<BE.Factura>
    {

        public int GetMaxId()
        {
            try
            {
                return int.Parse(DAL.Factura.GetInstance().GetMaxId().ToString());

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
                return DAL.Factura.GetInstance().Add(objAlta);
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
