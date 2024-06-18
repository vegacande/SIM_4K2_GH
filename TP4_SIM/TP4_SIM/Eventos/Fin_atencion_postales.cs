using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Distribuciones;

namespace TP4_SIM.Eventos
{
    public class Fin_atencion_postales : Inicio
    {

        public string Nombre { get; set; }
        public double RND { get; set; }
        public double Tiempo { get; set; }
        public double Hora { get; set; }
        public Distribucion distribucion { get; set; }

        public Fin_atencion_postales(Distribucion distro)
        {
            Nombre = "Fin postales";
            this.distribucion = distro;
        }

        public Fin_atencion_postales(Fin_atencion_postales fin_atencion, Distribucion distribucion, bool keep)
        {
            if (keep)
            {
                this.distribucion = distribucion;
                this.RND = fin_atencion.RND;
                this.Tiempo = fin_atencion.Tiempo;
            }
            this.Hora = fin_atencion.Hora;
        }

        public Fin_atencion_postales(Distribucion distro, VectorEstado nuevaFila)
        {
            this.distribucion = distro;
            generarRND();
            generarTiempo();
            generarHora(nuevaFila.Reloj);
            //nuevaFila.Empleado_postales.Estado = "L";
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
        public Fin_atencion_postales()
        {
        }

        public Fin_atencion_postales(double reloj)
        {
            this.Hora = Tiempo + reloj;
        }
        public Fin_atencion_postales(Fin_atencion_postales fin)
        {
            this.Hora = fin.Hora;
        }
    }
}
