using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Utilidades
{
    public class Utilidades
    {
        static readonly double ajusteCantidadDecimales = Math.Pow(10, 4);

        public static double Truncar(double aTruncar)
        {
            return Math.Truncate(aTruncar * ajusteCantidadDecimales) / ajusteCantidadDecimales;
        }
    }
}
