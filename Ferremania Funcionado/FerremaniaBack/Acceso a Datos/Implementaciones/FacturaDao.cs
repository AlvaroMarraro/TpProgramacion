using FerremaniaBack.Acceso_a_Datos.Interfaces;
using FerremaniaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Acceso_a_Datos.Implementaciones
{
    public class FacturaDao : IFacturaDao
    {
        public List<FormaPago> ConsultaFormaPago()
        {
            DataTable tabla = HelperDao.GetHelperDao().ConsultaSQL("SP_TRAER_FORMA_PAGO");
            List<FormaPago> clientes = new List<FormaPago>();
            foreach (DataRow row in tabla.Rows)
            {
                FormaPago oFormaPago = new FormaPago();
                oFormaPago.CodFormaPago = Convert.ToInt32(row["id_formaPago"]);
                oFormaPago.Nombre = row["nombre"].ToString();

                clientes.Add(oFormaPago);
            }

            return clientes;
        }

        public bool GenerarFactura(Factura oFactura)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog=FERREMANIA3;Integrated Security=True");
            
            bool flag = true;
            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@idFormaPago", oFactura.CodFormaPago);
                cmdMaestro.Parameters.AddWithValue("@codCliente", oFactura.CodCliente);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@facturaNro";
                param.SqlDbType = SqlDbType.Int;               
                param.Direction = ParameterDirection.Output;
                param.Value = GetNextFacturaId();
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();
                
                int nroFactura = (int)param.Value;


                foreach (DetalleFactura det in oFactura.Detalles)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@codArticulo", det.Articulo.Cod_articulo);
                    cmd.Parameters.AddWithValue("@cantidad ", det.Cantidad);
                    cmd.Parameters.AddWithValue("@facturaNro", nroFactura);
                    cmd.Parameters.AddWithValue("@precio ", det.Precio);

                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();

            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                flag = false;
                
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return flag;
        }

        public List<Articulo> GetArticulos()
        {
            List<Articulo> lst = new List<Articulo>();
            SqlConnection cnn = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog=FERREMANIA3;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_ARTICULOS", cnn);

            cmd2.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());

            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                Articulo oArticulo = new Articulo();
                oArticulo.Cod_articulo = Convert.ToInt32(row["cod_articulo"].ToString());
                oArticulo.Descripcion = row["descripcion"].ToString();
                oArticulo.Pre_unitario = Convert.ToDouble(row["pre_unitario"].ToString());


                lst.Add(oArticulo);
            }

            return lst;
        }

        public int GetNextFacturaId()
        {
            return HelperDao.GetHelperDao().ProximoID("SP_PROXIMO_ID");
        }
    }
}
