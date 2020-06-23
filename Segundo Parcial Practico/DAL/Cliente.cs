using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Cliente :BE.ICrud<BE.Cliente>
    {
                //Opcion 1
        string cconnstr = @"Data Source=('C:\Segundo Parcial Practico\Segundo Parcial Practico\')\servidor;Initial Catalog=LUG2018;Integrated Security=True";

        private static Cliente _instancia = null;

        private Cliente()
        { }

        public static Cliente GetInstance()
        {
            if (_instancia==null)
            {
                _instancia = new Cliente();
            }

            return _instancia;
        }


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
                string SP = "sp_get_all_clientes";
                return Helper.sqlHelper.GetInstance(cconnstr).ExecuteReader(SP);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
