using FerremaniaBack.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Servicios
{
    public abstract class AbstractServiceFactory
    {
        public abstract IClienteServicios CrearService();
    }
}
