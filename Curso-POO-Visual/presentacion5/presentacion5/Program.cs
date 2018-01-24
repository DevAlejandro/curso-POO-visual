using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {   
            // el objeto es empleado, siempre hay que hacer la instanciacion del costructor a la variable
            clsEmpleados empleado; // variable empleado de clase Empleados
            empleado = new clsEmpleados();  // instanciacion: es para asignarle un espacio de memoria SIEMPRE HACERLO.

            empleado.Edad = 25;
            empleado.Nombre = "Kripto Op7";
            empleado.SueldoDiario = 12.25m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.ForegroundColor = ConsoleColor.Green; // foreground = color del texto , background = fondo del texto
            Console.WriteLine("El salario de " + empleado.Nombre + " es : " + total.ToString("C")); // + = concatenar , C = convertir a moneda
            Console.ResetColor();
            Console.WriteLine(" PRESIONE ENTER PARA SALIR....." );
            Console.ReadLine(); // readline = enter para salir, readkey = presionar una tecla para salir

        }
    }
}
