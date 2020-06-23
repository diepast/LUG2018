using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class DetalleFactura : BE.ICrud<BE.DetalleFactura>
    {

        public int Add(BE.DetalleFactura objAlta)
        {
            try
            {
                
                return DAL.DetalleFactura.GetInstance().Add(objAlta);
            }
            catch (Exception)
            {
                
                throw;
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


        public System.Data.DataTable SelectAlldt()
        {
            throw new NotImplementedException();
        }
    }
}
