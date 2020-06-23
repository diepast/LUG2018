using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAL
{
    public class Producto : BE.ICrud<BE.Producto>
    {
        //Opcion 1
        string cconnstr = @"Data Source=('C:\Segundo Parcial Practico\Segundo Parcial Practico\')\servidor;Initial Catalog=FacturacionLUG;Integrated Security=True";

        private static Producto _instancia = null;

        private Producto()
        { }

        public static Producto GetInstance()
        {
            if (_instancia==null)
            {
                _instancia = new Producto();
            }

            return _instancia;
        }





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


        public DataTable SelectAlldt()
        {
            try
            {
                string SP = "sp_get_all_productos";
                return Helper.sqlHelper.GetInstance(cconnstr).ExecuteReader(SP);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
