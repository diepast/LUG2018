using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Helper
{
    public class sqlHelper
    {
        private static sqlHelper instance = null;
        private string Cconnstr;
        private SqlConnection _cn;
        private SqlCommand _cm;
        private DataTable _dt;


        private sqlHelper(string con)
        {
            this.Cconnstr = con;
        }

        public static sqlHelper GetInstance(string conection)
        {
            if (instance == null)
                instance = new sqlHelper(conection);

            return instance;
        }


        public bool ExecuteQuery(string Query)
        {
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm= new SqlCommand(Query,_cn);
                bool retorno = false;
                _cm.CommandType = System.Data.CommandType.Text;
                _cm.CommandText = Query;
                _cn.Open();
                if (_cm.ExecuteNonQuery()!=0)
                {
                    retorno = true;
                }    
                _cn.Close();
                return retorno;
            }

            catch (Exception ex)
            {
                
                throw ex;

            }

        }
        public bool ExecuteScalar(string sp, List<SqlParameter> listaparametros)
        {
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(sp, _cn);
                bool retorno = false;
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                _cm.CommandText = sp;
                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                _cn.Open();
                if (int.Parse(_cm.ExecuteScalar().ToString())==1)
                {
                    retorno = true;
                }

                _cn.Close();
                return retorno;
            }

            catch (Exception ex)
            {
                
                throw ex;

            }

        }

        public bool Executereader_bool(string sp, List<SqlParameter> listaparametros)
        {
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(sp, _cn);
                bool retorno = false;
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                _cm.CommandText = sp;
                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                _cn.Open();
                SqlDataReader _dr = _cm.ExecuteReader();
                if (_dr.HasRows)
                {
                    retorno = true;
                }

                _cn.Close();
                return retorno;
            }

            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public bool ExecuteQuery(string sp, List<SqlParameter> listaparametros)
        {
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(sp,_cn);
                bool retorno = false;
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                _cm.CommandText = sp;
                if (listaparametros!=null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                _cn.Open();
                SqlDataReader dr = _cm.ExecuteReader();
                if (dr.HasRows)
                {
                    retorno = true;
                }
                    
                _cn.Close();
                return retorno;
            }

            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public bool ExecuteQuery(string sp, List<SqlParameter> listaparametros, SqlParameter[] Pparametros)
        {
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(sp,_cn);
                bool retorno = false;
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                _cm.CommandText = sp;
                if (Pparametros != null)
                    _cm.Parameters.AddRange(Pparametros);
                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                _cn.Open();

                if (_cm.ExecuteNonQuery() != 0)
                {
                    retorno = true;
                }
                _cn.Close();
                return retorno;
            }

            catch (Exception ex)
            {
                
                throw ex;

            }

        }

        public DataTable ExecuteReader(string pSP, List<SqlParameter> listaparametros)
        {

            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(pSP, _cn);
                _dt = new DataTable();
                _cn.Open();
                _cm.CommandType = System.Data.CommandType.StoredProcedure;

                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                SqlDataReader Lector = _cm.ExecuteReader();
                _dt.Load(Lector);
                _cn.Close();
                return _dt;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }


        public DataTable ExecuteReader(string pSP, List<SqlParameter> listaparametros ,SqlParameter[] Pparametros)
        {
            
            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(pSP, _cn);
                _dt= new DataTable();
                _cn.Open();
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                if (Pparametros != null)
                    _cm.Parameters.AddRange(Pparametros);
                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                SqlDataReader Lector = _cm.ExecuteReader();
                _dt.Load(Lector);
                _cn.Close();
                return _dt;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        public DataTable ExecuteReader(string query)
        {

            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(query, _cn);
                _dt = new DataTable();
                _cn.Open();
                _cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader Lector = _cm.ExecuteReader();
                _dt.Load(Lector);
                _cn.Close();
                return _dt;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }


        public int ExecuteScalar(string query)
        {

            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(query, _cn);
                _dt = new DataTable();
                _cn.Open();
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                int retorno = 1;
                Object obj = _cm.ExecuteScalar().ToString();
                if (!(obj.Equals(null) || (obj.ToString()=="")))
                {
                    retorno = int.Parse(obj.ToString());
                }
                _cn.Close();
                return retorno;// (retorno = retorno + 1);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int ExecuteScalarint(string query, List<SqlParameter> listaparametros)
        {

            try
            {
                _cn = new SqlConnection(Cconnstr);
                _cm = new SqlCommand(query, _cn);
                _dt = new DataTable();
                _cn.Open();
                _cm.CommandType = System.Data.CommandType.StoredProcedure;
                if (listaparametros != null)
                {
                    foreach (SqlParameter item in listaparametros)
                    {
                        _cm.Parameters.Add(item);
                    }

                }
                int retorno = 0;
                Object obj= int.Parse(_cm.ExecuteScalar().ToString());
                if (!obj.Equals(null))
                {
                    retorno = int.Parse(obj.ToString());
                }
                
                _cn.Close();
                return retorno;// (retorno = retorno + 1);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
       
}
