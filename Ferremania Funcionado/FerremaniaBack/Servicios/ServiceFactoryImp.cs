using FerremaniaBack.Servicios.Implementaciones;
using FerremaniaBack.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Servicios
{
    public class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IClienteServicios CrearService()
        {
            return new ClienteServicios();
        }
    }
}
