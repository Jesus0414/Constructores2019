using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Jesús";
            contacto1.Celular = "(644) 4 47 7007";
            contacto1.Correo = "jesus140400@outlook.com";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Dirección: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Juan", "(644) 0 00 0000", "juan@correo.com");

            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Correo: " + contacto2.Correo);
            Console.WriteLine("Dirección: " + contacto2.Direccion);



            Console.Read();
        }
    }
}
