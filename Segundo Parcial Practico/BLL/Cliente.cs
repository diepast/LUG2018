using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Cliente :BE.ICrud<BE.Cliente>
    {

        public int Add(BE.Cliente objAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(BE.Cliente objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Cliente objUpdate)
        {
            throw new NotImplementedException();
        }

        public BE.Cliente SelectById(BE.Cliente objSelect)
        {
            throw new NotImplementedException();
        }

        public List<BE.Cliente> SelectAll()
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable SelectAlldt()
        {
            try
            {
                return DAL.Cliente.GetInstance().SelectAlldt();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
