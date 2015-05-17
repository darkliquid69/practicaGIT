using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Version 1.0
namespace proyecto
{
    public class Program
    {
        public static void Main(string[] args)
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
            int cont = 0;
            Console.WriteLine("Holaaa, esta es la funcion de leo");

            for(int i=0; i<100; i++){
            	Console.WriteLine("Estoy Trabajando..." + (i+1) + "%");
            }
        }
    }
}