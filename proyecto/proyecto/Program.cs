using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Version 1.0
namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            funcion_salvi();
            funcion_leo();
        }

        public static void funcion_salvi()
        {
            Console.WriteLine("hola mundo...");
        }
        public static void funcion_leo()
        {
            Console.WriteLine("Holaaa, esta es la funcion de leo");

            for(int i=0; i<100; i++){
            	Console.WriteLine("Estoy Trabajando..." + (i+1) + "%");
            }

        }
    }
}