using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Objetos
{
    public class Empleado_reclamos
    {
        public string Estado { get; set; }
        public int Cola { get; set; }

        public Empleado_reclamos()
        {
            Estado = "Libre";
            Cola = 0;

        }
        public Empleado_reclamos(Empleado_reclamos e)
        {
            Estado = e.Estado;
            Cola = e.Cola;
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
            }
            return false;
        }
    }
}
