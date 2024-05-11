using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM_G6.LogicaNegocio
{
    public class Neg_Cliente
    {
        #region Atributos
        int nroCliente { get; set; }
        int cantPastelitos { get; set; }
        double precio { get; set; }
        #endregion

        #region Constructores
        public Neg_Cliente(int nroCliente, int cantPastelitos, double precio)
        {
            this.nroCliente = nroCliente;
            this.cantPastelitos = cantPastelitos;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public int cantidadDemanda()
        {
            return this.cantPastelitos;
        }

        public double cantidadUtilidad()
        {
            return cantPastelitos * this.precio;
        }
        #endregion
    }
}
