using FerremaniaBack.Acceso_a_Datos.Implementaciones;
using FerremaniaBack.Acceso_a_Datos.Interfaces;
using FerremaniaBack.Dominio;
using FerremaniaBack.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Servicios.Implementaciones
{
    public class ClienteServicios : IClienteServicios
    {
        private IClienteDao dao;

        public ClienteServicios()
        {
            dao = new ClienteDao();
        }
        public bool EliminarCliente(int codCliente)
        {
            return dao.DeleteCliente(codCliente);
        }

        public List<Cliente> getClientes()
        {
            return dao.GetClientes();
        }

        public bool modificarCliente(Cliente oCliente)
        {
            return dao.modificarCliente(oCliente);
        }

        public bool RegistrarCliente(Cliente oCliente)
        {
            return dao.registrarCliente(oCliente);
        }

        public List<ComboCliente> getClientesCombo()
        {
            return dao.getClientesCombo();
        }

        public List<Cliente> getClientes(List<Cliente> lst)
        {
            return dao.GetClientes();
        }
    
    }
}
