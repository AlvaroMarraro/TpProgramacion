using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Dominio
{
    public class Articulo
    {
        public int Cod_articulo { get; set; }
        public string Descripcion { get; set; }
        public double Pre_unitario { get; set; }
        
        


        public Articulo()
        {

        }

        public override string ToString()
        {

            return Cod_articulo.ToString() + "-" + Descripcion;

        }
    }
}
