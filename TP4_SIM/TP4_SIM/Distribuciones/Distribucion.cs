using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Distribuciones
{
    public interface Distribucion
    {
        List<double> generarVariables();
        double calcularValor(double v, double factorMultiplicador);
      
        double generarValor(double v);
    }
}
