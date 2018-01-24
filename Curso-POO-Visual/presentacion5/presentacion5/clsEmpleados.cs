using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion5
{
    //clase empleados 
    public class clsEmpleados
    {
        //propiedades de la clase empleado  

            //constructor : le da valores previos a los objetos
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        //propiedades de la clase Empleados, son publicas para poder ser accesibles 

        private string _Nombre; // encapsulamiento del campo _Nombre ,

        public string Nombre  // campo convertido en Propiedad comandos rapidos ( ctrl + R + E ) 
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public decimal SueldoDiario { get; set; } //comando rapido = prop + TAB (2 veces ) 


        public int Edad;

        //propiedad que recibe un entero con numero de dias y devuelve un decimal
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }


    }
}
