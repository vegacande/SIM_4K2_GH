using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Objetos
{
    public class Empleado_atencion
    {
        public string Estado { get; set; }
        public int Cola { get; set; }
        public int cantidadClientes { get; set; }

        public Empleado_atencion()
        {
            Estado = "Libre";
            Cola = 0;
            cantidadClientes = 0;

        }
        public Empleado_atencion(Empleado_atencion e)
        {
            Estado = e.Estado;
            Cola = e.Cola;
            cantidadClientes = e.cantidadClientes;

        }
        public bool estaLibre()
        {
            if (Estado.Equals("Libre"))
            {
                return true;
            }
            return false;
        }
        public bool hayCola()
        {
            if (Cola.Equals(0))
            {
                return true;
                //no hay cola
            }
            return false;
        }
    }
}
