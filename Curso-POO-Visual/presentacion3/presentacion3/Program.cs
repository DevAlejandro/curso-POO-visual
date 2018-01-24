using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;
            //conversion implicita de x a entero, se le llama caso. 
            // i = (int)x;
            // objeto convertir usa el metodo de entero 32 a la variable seleccionada entre parentesis.
            i = Convert.ToInt32(bandera);
            Console.WriteLine("El valor de i es : {0}", i);
            Console.WriteLine("El valor de x es : {0:C}", x);
            Console.WriteLine("El valor de cadena es : " + cadena);
            Console.WriteLine("Bandera : " + bandera.ToString());
            Console.WriteLine("Fecha : " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
