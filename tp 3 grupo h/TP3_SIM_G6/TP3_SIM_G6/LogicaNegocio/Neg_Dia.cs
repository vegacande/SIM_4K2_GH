using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM_G6.LogicaNegocio
{
    public class Neg_Dia
    {
        #region Atributos
        int nroDia { get; set; }
        List<Neg_Cliente> clientes { get; set; }
        int stock { get; set; }
        #endregion

        #region Constructores
        public Neg_Dia(int nroDia, List<Neg_Cliente> clientes, int stock)
        {
            this.nroDia = nroDia;
            this.clientes = clientes;
            this.stock = stock;
        }

        public Neg_Dia()
        {
        }
        #endregion

        #region Metodos
        public int cantidadClientes()
        {
            return this.clientes.Count;
        }

        public int cantidadDemanda()
        {
            int cantidad = 0;
            foreach (Neg_Cliente c in this.clientes)
            {
                cantidad += c.cantidadDemanda();
            }
            return cantidad;
        }

        public int getStock()
        {
            return this.stock;
        }

        public double getUtilidad()
        {
            double utilidad = 0;
            foreach (Neg_Cliente c in this.clientes)
            {
                utilidad += c.cantidadUtilidad();
            }
            return utilidad;
        }

        #endregion
    }
}
