using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int valor1 = 0, valor2 = 0;
            string cadena;
            Console.WriteLine("Digite el primer valor");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("Digite el segundo valor");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            if (valor1 == valor2) { 
                Console.WriteLine("Los valores son iguales");
            }

            else if (valor1 < valor2) { 
                Console.WriteLine("valor 1 es menor que valor 2");
            }

            else { 
                Console.WriteLine("Valor 2 es menos que valor 1");
            }

     
            Console.ReadKey();
        }
    }
}
