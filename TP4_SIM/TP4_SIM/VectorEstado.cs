using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Distribuciones;
using TP4_SIM.Eventos;
using TP4_SIM.Objetos;

namespace TP4_SIM
{
    public class VectorEstado
    {
        public string Evento { get; set; }
        public double Reloj { get; set; }

        // Eventos
        public Llegada_atencion Llegada_atencion { get; set; }
        public LLegada_envios LLegada_envios { get; set; }
        public Llegada_postales Llegada_postales { get; set; }
        public Llegada_reclamos Llegada_reclamos { get; set; }
        public Llegada_venta Llegada_Venta { get; set; }
        public Fin_atencion_atencion Fin_atencion_atencion { get; set; }
        public Fin_atencion_envio Fin_atencion_envio { get; set; }
        public Fin_atencion_postales fin_Atencion_Postales { get; set; }
        public Fin_atencion_reclamos fin_Atencion_Reclamos { get; set; }
        public Fin_atencion_venta fin_Atencion_Venta { get; set; }
       

        // Objetos Permanentes

        public Empleado_atencion Empleado_atencion { get; set; }
        public Empleado_envio Empleado_Envio { get; set; }
        public Empleado_postales Empleado_Postales { get; set; }
        public Empleado_reclamos Empleado_Reclamos { get; set; }
        public Empleado_venta Empleado_Venta { get; set; }


        // Métricas - Variables estadísticas

        public Metricas Metricas { get; set; }

        // Objetos Temporales

        public List<Cliente> ListaClientes { get; set; }
        
        // Otras variables auxiliares

        public VectorEstado(Dictionary<int, Distribucion> distribuciones)
        {
            Evento = "Inicialización";
            Reloj = 0;
            // Eventos
            Llegada_atencion = new Llegada_atencion(distribuciones[1]);
            Llegada_atencion.generarRND();
            Llegada_atencion.generarTiempo();
            Llegada_atencion.generarHora(0);

            LLegada_envios = new LLegada_envios(distribuciones[2]);
            LLegada_envios.generarRND();
            LLegada_envios.generarTiempo();
            LLegada_envios.generarHora(0);

            Llegada_postales = new Llegada_postales(distribuciones[3]);
            Llegada_postales.generarRND();
            Llegada_postales.generarTiempo();
            Llegada_postales.generarHora(0);

            Llegada_reclamos = new Llegada_reclamos(distribuciones[4]);
            Llegada_reclamos.generarRND();
            Llegada_reclamos.generarTiempo();
            Llegada_reclamos.generarHora(0);
                 
            Llegada_Venta = new Llegada_venta(distribuciones[5]);
            Llegada_Venta.generarRND();
            Llegada_Venta.generarTiempo();
            Llegada_Venta.generarHora(0);

            //!!!!!!!!!!!!!!!!   CREE 1 DE CADA UNO PERO SON VARIOS SEGUN EL SERVICIO, CHEQUEAR/hacer los q faltan
            Fin_atencion_atencion = new Fin_atencion_atencion(distribuciones[6]);   
            Fin_atencion_envio = new Fin_atencion_envio(distribuciones[7]);
            fin_Atencion_Postales = new Fin_atencion_postales(distribuciones[8]);
            fin_Atencion_Reclamos = new Fin_atencion_reclamos(distribuciones[9]);
            fin_Atencion_Venta = new Fin_atencion_venta(distribuciones[10]);

            // Objetos Permanentes
            Empleado_atencion = new Empleado_atencion();
            Empleado_Envio = new Empleado_envio();
            Empleado_Postales = new Empleado_postales();
            Empleado_Reclamos = new Empleado_reclamos();
            Empleado_Venta = new Empleado_venta();
           
            // Metricas
            Metricas = new Metricas();

            // Objetos Temporales
            ListaClientes = new List<Cliente>();
        }

        public VectorEstado(VectorEstado ve, Dictionary<int, Distribucion> distribuciones, bool keep = false)
        {
            // Mecanismo para copiar una fila de la simulación

            this.ListaClientes = new List<Cliente>();
            foreach (var cli in ve.ListaClientes)
            {
                this.ListaClientes.Add(new Cliente(cli));
            }
            
            this.Evento = ve.Evento;
            this.Reloj = ve.Reloj;
            this.Llegada_atencion = new Llegada_atencion(ve.Llegada_atencion, distribuciones[1], keep);
            this.LLegada_envios = new LLegada_envios(ve.LLegada_envios, distribuciones[2], keep);
            this.Llegada_postales = new Llegada_postales(ve.Llegada_postales, distribuciones[3], keep);
            this.Llegada_reclamos = new Llegada_reclamos(ve.Llegada_reclamos, distribuciones[4], keep);
            this.Llegada_Venta = new Llegada_venta(ve.Llegada_Venta, distribuciones[5], keep);

            //!!!!!!!!!!!!!!!!!PROBLEMA DEL FUTURO: para los fin tal vez solo haga falta el primer parametro
            //this.Fin_atencion_atencion = new Fin_atencion_atencion(ve.Fin_atencion_atencion, distribuciones[6], keep);
            //this.Fin_atencion_envio = new Fin_atencion_envio(ve.Fin_atencion_envio, distribuciones[7], keep);
            //this.fin_Atencion_Postales = new Fin_atencion_postales(ve.fin_Atencion_Postales, distribuciones[8], keep);
            //this.fin_Atencion_Reclamos = new Fin_atencion_reclamos(ve.fin_Atencion_Reclamos, distribuciones[9], keep);
            //this.fin_Atencion_Venta = new Fin_atencion_venta(ve.fin_Atencion_Venta, distribuciones[10], keep);

            this.Fin_atencion_atencion = new Fin_atencion_atencion(ve.Fin_atencion_atencion);
            this.Fin_atencion_envio = new Fin_atencion_envio(ve.Fin_atencion_envio);
            this.fin_Atencion_Postales = new Fin_atencion_postales(ve.fin_Atencion_Postales);
            this.fin_Atencion_Reclamos = new Fin_atencion_reclamos(ve.fin_Atencion_Reclamos);
            this.fin_Atencion_Venta = new Fin_atencion_venta(ve.fin_Atencion_Venta);

            this.Empleado_atencion = new Empleado_atencion();
            this.Empleado_Envio = new Empleado_envio();
            this.Empleado_Postales = new Empleado_postales();
            this.Empleado_Reclamos = new Empleado_reclamos();
            this.Empleado_Venta = new Empleado_venta();

            this.Metricas = new Metricas(ve.Metricas);

        }
         
        public (string, double) determinarSiguienteEvento()
        {
            List<(string, double)> Eventos = new List<(string, double)>();
            Eventos.Add(("Llegada Cliente Atencion", this.Llegada_atencion.HoraLlegada));
            Eventos.Add(("Llegada Cliente Envios", this.LLegada_envios.HoraLlegada));
            Eventos.Add(("Llegada Cliente Postales", this.Llegada_postales.HoraLlegada));
            Eventos.Add(("Llegada Cliente Reclamos", this.Llegada_reclamos.HoraLlegada));
            Eventos.Add(("Llegada Cliente Venta", this.Llegada_Venta.HoraLlegada));

            Eventos.Add(("Fin atencion", this.Fin_atencion_atencion.Hora));
            Eventos.Add(("Fin envio", this.Fin_atencion_envio.Hora));
            Eventos.Add(("Fin postales", this.fin_Atencion_Postales.Hora));
            Eventos.Add(("Fin reclamos", this.fin_Atencion_Reclamos.Hora));
            Eventos.Add(("Fin venta", this.fin_Atencion_Venta.Hora));
         
             
            double menor = Double.MaxValue;
            string siguienteEvento = "";
            for (int i = 0; i < Eventos.Count; i++)
            {
                if (Eventos[i].Item2 != 0 && Eventos[i].Item2 < menor)
                {
                    menor = Eventos[i].Item2;
                    siguienteEvento = Eventos[i].Item1;
                }
            }
            return (siguienteEvento, menor);

        }

        public string[] ToLista(int cantidadClientesTotales, int condicionCorte)
        {
            List<string> cadena = new List<string>();
            cadena.Add(this.Evento);
            cadena.Add(this.Reloj.ToString());
            // condicion ? rama verdadera : rama falsa
            cadena.Add(this.Llegada_atencion.RND != 0 ? this.Llegada_atencion.RND.ToString() : "");
            cadena.Add(this.Llegada_atencion.TiempoDeLlegada != 0 ? this.Llegada_atencion.TiempoDeLlegada.ToString() : "");
            cadena.Add(this.Llegada_atencion.HoraLlegada != 0 ? this.Llegada_atencion.HoraLlegada.ToString() : "");

            cadena.Add(this.LLegada_envios.RND != 0 ? this.LLegada_envios.RND.ToString() : "");
            cadena.Add(this.LLegada_envios.TiempoDeLlegada != 0 ? this.LLegada_envios.TiempoDeLlegada.ToString() : "");
            cadena.Add(this.LLegada_envios.HoraLlegada != 0 ? this.LLegada_envios.HoraLlegada.ToString() : "");

            cadena.Add(this.Llegada_postales.RND != 0 ? this.Llegada_postales.RND.ToString() : "");
            cadena.Add(this.Llegada_postales.TiempoDeLlegada != 0 ? this.Llegada_postales.TiempoDeLlegada.ToString() : "");
            cadena.Add(this.Llegada_postales.HoraLlegada != 0 ? this.Llegada_postales.HoraLlegada.ToString() : "");

            cadena.Add(this.Llegada_reclamos.RND != 0 ? this.Llegada_reclamos.RND.ToString() : "");
            cadena.Add(this.Llegada_reclamos.TiempoDeLlegada != 0 ? this.Llegada_reclamos.TiempoDeLlegada.ToString() : "");
            cadena.Add(this.Llegada_reclamos.HoraLlegada != 0 ? this.Llegada_reclamos.HoraLlegada.ToString() : "");

            cadena.Add(this.Llegada_Venta.RND != 0 ? this.Llegada_Venta.RND.ToString() : "");
            cadena.Add(this.Llegada_Venta.TiempoDeLlegada != 0 ? this.Llegada_Venta.TiempoDeLlegada.ToString() : "");
            cadena.Add(this.Llegada_Venta.HoraLlegada != 0 ? this.Llegada_Venta.HoraLlegada.ToString() : "");

         
            cadena.Add(this.Fin_atencion_atencion.Hora != 0 ? this.Fin_atencion_atencion.Hora.ToString() : "");
            cadena.Add(this.Fin_atencion_envio.Hora != 0 ? this.Fin_atencion_envio.Hora.ToString() : "");
            cadena.Add(this.fin_Atencion_Postales.Hora != 0 ? this.fin_Atencion_Postales.Hora.ToString() : "");
            cadena.Add(this.fin_Atencion_Reclamos.Hora != 0 ? this.fin_Atencion_Reclamos.Hora.ToString() : "");
            cadena.Add(this.fin_Atencion_Venta.Hora != 0 ? this.fin_Atencion_Venta.Hora.ToString() : "");

            cadena.Add(this.Empleado_atencion.Estado);
            cadena.Add(this.Empleado_atencion.Cola.ToString());
            cadena.Add(this.Metricas.cantidadClientesAtencion.ToString());

            cadena.Add(this.Empleado_Envio.Estado);
            cadena.Add(this.Empleado_Envio.Cola.ToString());
            cadena.Add(this.Metricas.cantidadClientesEnvios.ToString());

            cadena.Add(this.Empleado_Postales.Estado);
            cadena.Add(this.Empleado_Postales.Cola.ToString());
            cadena.Add(this.Metricas.cantidadClientesPostales.ToString());

            cadena.Add(this.Empleado_Reclamos.Estado);
            cadena.Add(this.Empleado_Reclamos.Cola.ToString());

            cadena.Add(this.Empleado_Venta.Estado);
            cadena.Add(this.Empleado_Venta.Cola.ToString());

            cadena.Add(this.Metricas.cantidadTotalClientes.ToString());


            var j = -1;
            foreach (Cliente cli in ListaClientes)
            {
                j++;
                if (j == condicionCorte)
                {
                    break;
                }
                cadena.Add(cli.Estado == "Muerto" ? "" : cli.Estado);
            }
            for (int i = 0; i < cantidadClientesTotales - this.ListaClientes.Count; i++)
            {
                j++;
                if (j == condicionCorte)
                    break;
                cadena.Add("");
            }
        
            return cadena.ToArray();
        }
    }
}
