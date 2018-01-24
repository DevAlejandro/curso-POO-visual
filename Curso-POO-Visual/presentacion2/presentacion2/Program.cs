using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float y = 0.0f;
            double z = 0.0d;
            string cadena = "Hola Mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("el valor de i es : {0}", i);
            Console.WriteLine("El valor de x es : {0:C}", x);
            Console.WriteLine("El valor de y es : {0:F2}", y);
            Console.WriteLine("El valor de z es : {0:F2}", z);
            Console.WriteLine("El valor de cadena es :" + cadena);
            Console.WriteLine("El valor de Bandera es :"+  bandera.ToString());
            Console.WriteLine("El valor de fecha es : " + fecha.ToShortDateString());
            Console.ReadKey();



        }
    }
}
