using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM_G6.LogicaNegocio
{
    public class Fila
    {
        public int dia { get; set; }
        public int cantClientes { get; set; }
        public int cantPastelitos { get; set; }
        public int stockPastelitos { get; set; }
        public int stockAC { get; set; }
        public double ingreso { get; set; }
        public double ingresoAC { get; set; }
        public double costo { get; set; }
        public double costoAC { get; set; }
        public double utilidad { get; set; }
        public double utilidadAC { get; set; }


        public Fila(int dia, int cantClientes, int demanda, int stock, double utilidad, double utilidadAC)
        {
            this.dia = dia;
            this.cantClientes = cantClientes;
            this.cantPastelitos = demanda;
            this.stockPastelitos = stock;
            this.stockAC = stockAC;
            this.utilidad = utilidad;
            this.utilidadAC = utilidadAC;
        }

        public Fila()
        {
            this.dia = 0;
            this.cantClientes = 0;
            this.cantPastelitos = 0;
            this.stockPastelitos = 200;
            this.stockAC = 0;
            this.ingreso = 0;
            this.ingresoAC = 0;
            this.costo = 0;
            this.costoAC = 0;
            this.utilidad = 0;
            this.utilidadAC = 0;
        }
    }
}
