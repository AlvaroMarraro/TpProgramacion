using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Dominio
{
    public class Factura
    {
        public int FacturaNro { get; set; }
        public DateTime Fecha { get; set; }
        public int CodCliente { get; set; }
        public Double Total { get; set; }

        public int CodFormaPago { get; set; }

        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura item in Detalles)
            {
                total += item.CalcularSubTotal();
            }
            return total;

        }
    }
}
