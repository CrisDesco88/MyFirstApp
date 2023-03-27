using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Variables
    {
        public Variables() {
            int numero = 0;
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Intorduce tu ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Intoduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hola " + nombre);
            Console.Write("Vives en " + ciudad);
            Console.Write("Y tu edad es: " +  edad);

        
        }
    }
}
