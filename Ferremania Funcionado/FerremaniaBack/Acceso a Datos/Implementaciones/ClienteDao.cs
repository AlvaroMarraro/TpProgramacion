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
    public class ClienteDao : IClienteDao
    {
        public bool DeleteCliente(int codCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@codCliente", codCliente);
            int eliminado = HelperDao.GetHelperDao().EjecutarSQL("SP_ELIMINAR_CLIENTE", cmd);
            if (eliminado == 1)
            {
                return true;
            }
            return false;
        }

        public List<Cliente> GetByFilters(List<Cliente> criterios)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientebyDoc(int clienteDoc)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetClientes()
        {
            DataTable tabla = HelperDao.GetHelperDao().ConsultaSQL("SP_TRAER_CLIENTES");
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow row in tabla.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.CodCliente = Convert.ToInt32(row["cod_cliente"]);
                cliente.DocCliente = Convert.ToInt32(row["doc_cliente"]);
                cliente.NombreCliente = row["nom_cliente"].ToString();
                cliente.ApellidoCliente = row["ape_cliente"].ToString();
                cliente.Calle = row["calle"].ToString();
                cliente.Altura = Convert.ToInt32(row["altura"]);
                cliente.NroTel = Convert.ToInt32(row["nro_tel"]);
                cliente.Email = row["e-mail"].ToString();

                clientes.Add(cliente);
            }

            return clientes;
        }

        public bool modificarCliente(Cliente oCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@codCliente", oCliente.CodCliente);
            cmd.Parameters.AddWithValue("@docCliente", oCliente.DocCliente);
            cmd.Parameters.AddWithValue("@nombre", oCliente.NombreCliente);
            cmd.Parameters.AddWithValue("@apellido", oCliente.ApellidoCliente);
            cmd.Parameters.AddWithValue("@calle", oCliente.Calle);
            cmd.Parameters.AddWithValue("@altura", oCliente.Altura);
            cmd.Parameters.AddWithValue("@nroTel", oCliente.NroTel);
            cmd.Parameters.AddWithValue("@email", oCliente.Email);
            int registrado = HelperDao.GetHelperDao().EjecutarSQL("SP_MODIFICAR_CLIENTE", cmd);
            if (registrado == 1)
            {
                return true;
            }
            return false;
        }

        public bool registrarCliente(Cliente oCliente)
        {
            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@codCliente", oCliente.CodCliente);
            cmd.Parameters.AddWithValue("@docCliente", oCliente.DocCliente);
            cmd.Parameters.AddWithValue("@nombre", oCliente.NombreCliente);
            cmd.Parameters.AddWithValue("@apellido", oCliente.ApellidoCliente);
            cmd.Parameters.AddWithValue("@calle", oCliente.Calle);
            cmd.Parameters.AddWithValue("@altura", oCliente.Altura);
            cmd.Parameters.AddWithValue("@nroTel", oCliente.NroTel);
            cmd.Parameters.AddWithValue("@email", oCliente.Email);
            int registrado = HelperDao.GetHelperDao().EjecutarSQL("SP_INSERTAR_CLIENTE", cmd);
            if (registrado == 1)
            {
                return true;
            }
            return false;
        }

        public bool SaveCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<ComboCliente> getClientesCombo()
        {
            DataTable tabla = HelperDao.GetHelperDao().ConsultaSQL("SP_TRAER_COMBO_CLIENTES");
            List<ComboCliente> clientes = new List<ComboCliente>();
            foreach (DataRow row in tabla.Rows)
            {
                ComboCliente cliente = new ComboCliente();
                cliente.codCliente = Convert.ToInt32(row["cod_cliente"]);
                cliente.dato = row["Datos"].ToString();               

                clientes.Add(cliente);
            }

            return clientes;
        }

    }
}
