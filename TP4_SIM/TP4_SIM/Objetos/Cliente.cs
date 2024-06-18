using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Objetos
{
    public class Cliente
    {
        public string Estado { get; set; }

        public Cliente()
        {
            Estado = "SE";
        }
        public Cliente(string estado)
        {
            Estado = estado;
        }
        public Cliente(Cliente c)
        {
            Estado = c.Estado;
        }
    }
}
