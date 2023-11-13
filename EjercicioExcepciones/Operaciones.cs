using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        //Creamos los metodos para las operaciones:



        //Metodo para sumar los dos números
        public double Sumar(double a, double b)
        {
            return a + b;
        }



        //Metodo para restar los dos números
        public double Restar(double a, double b)
        {
            return a - b;
        }


        //Metodo para multplicar los dos números
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }


        //Metodo para dividir los dos números, aca podemos lanzar una excepcion por si se quiere dividir por cero
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                // Excepcion si se quiere dividir por cero 
                throw new DivideByZeroException();   
            }

            return a / b;
        }
    }
}
