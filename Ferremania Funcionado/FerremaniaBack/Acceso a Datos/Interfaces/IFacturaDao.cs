using FerremaniaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Acceso_a_Datos.Interfaces
{
    public interface IFacturaDao
    {
        List<Articulo> GetArticulos();
        List<FormaPago> ConsultaFormaPago();
        int GetNextFacturaId();
        bool GenerarFactura(Factura oFactura);
       
    }
}
