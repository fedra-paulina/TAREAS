using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string Nombre, Telefono, Correo, Ocupación;

            Console.WriteLine("Cual es tu Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("introduce tu numero telefonico");
            Telefono = Console.ReadLine();

            Console.WriteLine("introduce tu correo");
            Correo = Console.ReadLine();

            Console.WriteLine("Ocupáción");
            Ocupación = Console.ReadLine();

            int e;
            Console.WriteLine("cual es tu edad");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e);
            if (e <= 17)

            {
                Console.WriteLine("estas chavo");

            }
        }
    }

}

