using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contacto()
        {
            Nombre = "Sin nombre";
            Celular = "Sin celular";
            Telefono = "Sin teléfono";
            Correo = "Sin correo";
            Direccion = "Sin dirección";
        }

        public Contacto(string nombre, string celular, string correo)
        {
            Nombre = nombre;
            Celular = celular;
            Telefono = "Sin teléfono";
            Correo = correo;
            Direccion = "Sin dirección";
        }
        public Contacto(string nombre, string celular, string correo, string telefono, string direccion)
        {
            Nombre = nombre;
            Celular = celular;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
