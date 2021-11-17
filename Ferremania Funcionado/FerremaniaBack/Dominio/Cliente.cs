using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerremaniaBack.Dominio
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public int DocCliente { get; set; }

        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int NroTel { get; set; }
        public string Email { get; set; }
        public DateTime FechaBaja { get; set; }

        public Cliente(int cod, int documento, string nombre, string apellido,
            string calle, int altura, int Tel, string email, DateTime FecBaja)
        {
            CodCliente = cod;
            DocCliente = documento;
            NombreCliente = nombre;
            ApellidoCliente = apellido;
            Calle = calle;
            Altura = altura;
            NroTel = Tel;
            Email = email;
            FechaBaja = FecBaja;
        }

        public Cliente()
        {

        }
        public override string ToString()
        {
            string mensaje;
            return mensaje = "Nombre: " + NombreCliente + "\n" +
                             "Apellido: " + ApellidoCliente + "\n" +
                             "DNI: " + DocCliente;

        }
    }
}
