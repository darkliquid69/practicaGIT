using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while (cont == 10)
            {
                Console.WriteLine("hola");
                cont++;
            }
        }
    }
}