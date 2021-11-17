using FerremaniaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Servicios.Interfaces
{
    public interface IClienteServicios
    {
        public List<Cliente> getClientes();

        public bool modificarCliente(Cliente oCliente);
        public bool RegistrarCliente(Cliente oCliente);
        public bool EliminarCliente(int codCliente);
        public List<Cliente> getClientes(List<Cliente> lst);
       
    }
}
