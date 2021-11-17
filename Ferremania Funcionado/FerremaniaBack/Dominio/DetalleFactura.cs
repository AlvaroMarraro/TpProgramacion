using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Dominio
{
    public class DetalleFactura
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public FormaPago FormaPago { get; set; }
        public DetalleFactura()
        {
            Articulo = new Articulo();
            Cantidad = 0;
        }
        public double CalcularSubTotal()
        {
            return Articulo.Pre_unitario * Cantidad;
        }
    }
}
