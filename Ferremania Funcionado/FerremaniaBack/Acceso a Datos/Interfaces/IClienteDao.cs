using FerremaniaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Acceso_a_Datos.Interfaces
{
    public interface IClienteDao
    {
        List<Cliente> GetClientes();
        Cliente GetClientebyDoc(int clienteDoc);
        bool SaveCliente(Cliente cliente);
        List<Cliente> GetByFilters(List<Cliente> criterios);

        bool DeleteCliente(int codCliente);
        bool registrarCliente(Cliente oCliente);
        bool modificarCliente(Cliente oCliente);
        List<ComboCliente> getClientesCombo();
    }
}
