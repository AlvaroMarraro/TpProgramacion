using FerremaniaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Servicios.Interfaces
{
    public interface IFacturaService
    {
        public List<Articulo> ConsultarArticulos();
        public int ObtenerProximaFacturaID();

        public List<FormaPago> ConsultarFormaPago();
        public bool GrabarFactura(Factura oFactura);


    }
}
