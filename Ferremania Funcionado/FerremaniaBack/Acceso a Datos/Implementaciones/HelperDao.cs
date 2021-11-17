using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Acceso_a_Datos.Implementaciones
{
    class HelperDao
    {
        private string string_conexion;
        private static HelperDao instance = new HelperDao();

        //declaro variable que almacerá un objeto <cmd> del tipo <SqlConnection>
        private SqlConnection _conexion;

        //declaro variable que almacerá un objeto <cmd> del tipo <SqlCommand>
        private SqlCommand _cmd;

        private HelperDao()
        {

            string_conexion = @"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog=FERREMANIA3;Integrated Security=True";

        }

        public static HelperDao GetHelperDao()
        {
            if (instance == null)
                instance = new HelperDao();
            return instance;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        public DataTable ConsultaSQL(string storeName)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeName;
            tabla.Load(cmd.ExecuteReader());
            this.CloseConnection(cnn);
            return tabla;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        public int EjecutarSQL(string storeP, SqlCommand sqlcmd)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            cmd = sqlcmd;
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeP;
            afectadas = cmd.ExecuteNonQuery();
            this.CloseConnection(cnn);
            return afectadas;
        }


        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public void CloseConnection()
        {
            if (_conexion.State == ConnectionState.Open)
            {
                //cierra la conexión con la base de datos
                _conexion.Close();
            }
        }

        public void Conectar()
        {
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
            //asigan al objeto <conexion> la cadena de conexion
            _conexion.ConnectionString = string_conexion;
            //agrega la conexion (se crea el pipe entre la aplicación y la base de datos)
            _conexion.Open();
            //se comunica al objeto <cmd> sobre que conexion debe trabajar
            _cmd.Connection = _conexion;
            //se establece el tipo de comando que va ha ejecutar
            _cmd.CommandType = CommandType.Text;
        }

        public SqlTransaction IniciarTransaccion()
        {
            Conectar();
            var transaccion = _conexion.BeginTransaction();
            _cmd.Transaction = transaccion;
            return transaccion;
        }

        public int EjecutarTransaccionSQL(string strSql)
        {
            var id = 0;
            _cmd.CommandText = strSql;

            if (_cmd.ExecuteNonQuery() > 0)
            {
                string consultaGetId = "Select @@Identity";
                _cmd.CommandText = consultaGetId;
                id = int.Parse(_cmd.ExecuteScalar()?.ToString());
            }
            return id;
        }

        public void EjecutarUpdateTransaccionSQL(string strSql)
        {
            _cmd.CommandText = strSql;
            _cmd.ExecuteNonQuery();
        }

        public DataTable ConsultaDuranteTransaccion(string comando)
        {

            _cmd.CommandText = comando;
            //instancia un objeto <tabla> del tipo DataTable
            DataTable tabla = new DataTable();

            tabla.Load(_cmd.ExecuteReader());

            //devuelve el valor calculado a través de la función
            return tabla;
        }
        public int ProximoID(string nombreSP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int nro_Factura = 0;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                DataTable resultado = HelperDao.GetHelperDao().ConsultaSQL("SP_PROXIMO_ID");
                foreach (DataRow item in resultado.Rows)
                {
                    if (item["nro_Factura"].ToString() != "")
                    {
                        nro_Factura = Convert.ToInt32(item["nro_Factura"]);
                    }
                }
                return nro_Factura + 1;
            }

            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

        }

    }
}
