using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM
{
    public class Metricas
    {
        public int cantidadTotalClientes {  get; set; }
        public int cantidadClientesAtencion {  get; set; }
        public int cantidadClientesEnvios { get; set; }
        public int cantidadClientesPostales { get; set; }

        public Metricas()
        {
            cantidadTotalClientes = 0;
            cantidadClientesAtencion = 0;
            cantidadClientesEnvios = 0;
            cantidadClientesPostales = 0;
        }

        public Metricas(Metricas m)
        {
            cantidadTotalClientes = m.cantidadTotalClientes;
            cantidadClientesAtencion = m.cantidadClientesAtencion;
            cantidadClientesEnvios = m.cantidadClientesEnvios;
            cantidadClientesPostales = m.cantidadClientesPostales;
        }
    }
}
