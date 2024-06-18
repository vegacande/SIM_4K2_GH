using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Utilidades;

namespace TP4_SIM.Distribuciones
{
    public class Exponencial : Distribucion
    {
        public Exponencial()
        {
        }

        public double media { get; set; }
        public double lambda { get; set; }
        public int sizeMuestra { get; set; }
        public List<double> rnds { get; set; }
        public List<double> variables { get; set; }
        public double max { get; set; }
        public double min { get; set; }

        public Exponencial(double media)
        {
            this.media = media;
        }
        public Exponencial(double media, double lambda, int sizeMuestra, List<double> rnds)
        {
            this.media = media;
            this.lambda = lambda;
            this.sizeMuestra = sizeMuestra;
            this.rnds = rnds;
        }

        // Método que genera todas las variables para la distribución
        public List<double> generarVariables()
        {
            double factorMultiplicador = (media == 0) ? 1 / lambda : media;
            variables = new List<double>();
            for (int i = 0; i < sizeMuestra; i++)
            {
                double variable = calcularValor(rnds[i], factorMultiplicador);
                variables.Add(variable);
            }
            return variables;
        }

        public double generarValor(double rnd)
        {
            double variable = -media * Math.Log(1 - rnd);
            return Utilidades.Utilidades.Truncar(variable);
        }

        //Método que genera un valor aleatorio para la distribución exponencial
        public double calcularValor(double v, double factorMultiplicador)
        {
            double variable = -factorMultiplicador * Math.Log(1 - v);
            return Math.Truncate(variable * 10000) / 10000;
        }

    }
}
