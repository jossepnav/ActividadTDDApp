using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0)
                return -1;

            long factorial = 1;

            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
