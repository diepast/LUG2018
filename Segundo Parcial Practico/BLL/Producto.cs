using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Producto :BE.ICrud<BE.Producto>
    {

        public int Add(BE.Producto objAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(BE.Producto objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Producto objUpdate)
        {
            throw new NotImplementedException();
        }

        public BE.Producto SelectById(BE.Producto objSelect)
        {
            throw new NotImplementedException();
        }

        public List<BE.Producto> SelectAll()
        {
            throw new NotImplementedException();

        }


        public System.Data.DataTable SelectAlldt()
        {
            try
            {
                return DAL.Producto.GetInstance().SelectAlldt();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
