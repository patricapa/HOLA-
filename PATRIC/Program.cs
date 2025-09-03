using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hola gentita,¿cual es su nombre?: ");
                string nombre = Console.ReadLine();

            Console.Write("¿Cúal es su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cúal es su statura?: ");
            decimal estatura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"mi nombre es {nombre}, mi edad es {edad} y mi statura es {estatura:N2}");

        }
    }
}
