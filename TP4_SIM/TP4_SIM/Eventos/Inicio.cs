using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM.Eventos
{
    public interface Inicio
    {
        double generarRND();
        double generarTiempo();
        double generarHora(double reloj);

    }
}
