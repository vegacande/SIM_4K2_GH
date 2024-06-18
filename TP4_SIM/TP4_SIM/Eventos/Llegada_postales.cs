using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Distribuciones;

namespace TP4_SIM.Eventos
{
    public class Llegada_postales : Inicio
    {

        public string Nombre { get; set; }
        public double RND { get; set; }
        public double TiempoDeLlegada { get; set; }
        public double HoraLlegada { get; set; }
        public Distribucion distribucion { get; set; }
        public Llegada_postales(Distribucion distro)
        {
            Nombre = "Llegada Cliente Postales";
            distribucion = distro;
        }

        public Llegada_postales(string nombre, double rND, double tiempoDeLlegada, double horaLlegada, Distribucion distribucion)
        {
            Nombre = nombre;
            RND = rND;
            TiempoDeLlegada = tiempoDeLlegada;
            HoraLlegada = horaLlegada;
            this.distribucion = distribucion;
        }

        public Llegada_postales(Llegada_postales llegadaCliente, Distribucion distribucion, bool keep)
        {
            if (keep)
            {
                this.distribucion = distribucion;
                this.RND = llegadaCliente.RND;
                this.TiempoDeLlegada = llegadaCliente.TiempoDeLlegada;
            }
            this.HoraLlegada = llegadaCliente.HoraLlegada;
        }

        public Llegada_postales(Distribucion distro, double nuevoReloj)
        {
            Nombre = "Llegada Cliente Postales";
            distribucion = distro;
            generarRND();
            generarTiempo();
            generarHora(nuevoReloj);
        }

        public double generarHora(double reloj)
        {
            HoraLlegada = reloj + TiempoDeLlegada;
            return HoraLlegada;
        }

        public double generarRND()
        {
            Random random = new Random();
            RND = random.NextDouble();
            return RND;
        }


        public double generarTiempo()
        {
            TiempoDeLlegada = distribucion.generarValor(RND);
            return TiempoDeLlegada;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
    }
}
