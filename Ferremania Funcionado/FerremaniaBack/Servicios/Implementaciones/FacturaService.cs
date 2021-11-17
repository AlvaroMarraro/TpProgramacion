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
    public class FacturaService : IFacturaService
    {
        private IFacturaDao dao;

        public FacturaService()
        {
            dao = new FacturaDao();
        }
        public List<Articulo> ConsultarArticulos()
        {
            return dao.GetArticulos();
        }

        public List<FormaPago> ConsultarFormaPago()
        {
            return dao.ConsultaFormaPago();
        }

        public int ObtenerProximaFacturaID()
        {
            return dao.GetNextFacturaId();
        }

        public bool GrabarFactura(Factura oFactura)
        {
            return dao.GenerarFactura(oFactura);
        }
    }
}
