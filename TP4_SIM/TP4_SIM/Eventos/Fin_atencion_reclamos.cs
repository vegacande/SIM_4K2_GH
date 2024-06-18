using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Distribuciones;

namespace TP4_SIM.Eventos
{
    public class Fin_atencion_reclamos : Inicio
    {

        public string Nombre { get; set; }
        public double RND { get; set; }
        public double Tiempo { get; set; }
        public double Hora { get; set; }
        public Distribucion distribucion { get; set; }

        public Fin_atencion_reclamos(Distribucion distro)
        {
            Nombre = "Fin reclamos";
            this.distribucion = distro;
        }

        public Fin_atencion_reclamos(Fin_atencion_reclamos fin_atencion, Distribucion distribucion, bool keep)
        {
            if (keep)
            {
                this.distribucion = distribucion;
                this.RND = fin_atencion.RND;
                this.Tiempo = fin_atencion.Tiempo;
            }
            this.Hora = fin_atencion.Hora;
        }

        public Fin_atencion_reclamos(Distribucion distro, VectorEstado nuevaFila)
        {
            this.distribucion = distro;
            generarRND();
            generarTiempo();
            generarHora(nuevaFila.Reloj);
            //nuevaFila.Empleado_reclamos.Estado = "L";
        }

        public double generarHora(double reloj)
        {
            Hora = reloj + Hora;
            return Hora;
        }

        public double generarRND()
        {
            Random random = new Random();
            RND = random.NextDouble();
            return RND;
        }

        public double generarTiempo()
        {
            Tiempo = distribucion.generarValor(RND);
            return Tiempo;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
        //////
        public Fin_atencion_reclamos()
        {
        }

        public Fin_atencion_reclamos(double reloj)
        {
            this.Hora = Tiempo + reloj;
        }
        public Fin_atencion_reclamos(Fin_atencion_reclamos fin)
        {
            this.Hora = fin.Hora;
        }
    }
}
