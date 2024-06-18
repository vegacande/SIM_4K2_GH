using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM.Distribuciones;
using TP4_SIM.Eventos;
using TP4_SIM;
using TP4_SIM.Objetos;

namespace TP4_SIM
{
    public class GestorColas
    {
        public int mostrarDesde { get; set; }
        public int cantidadIteraciones { get; set; }
        public VectorEstado[] resultadosSimulacion { get; set; }
        public Dictionary<int, Distribucion> distribuciones { get; set; }
        public Metricas metricasFinales { get; set; }

        //aca podria ir lo de la interrupcion

        public bool desdeActivo = false; // Nos sirve para matar objetos, no para desligarlos o destrirlos

        public GestorColas(int mostrarDesde, int cantidadIteraciones,

            //medias 
           double mdLLegadaAtencion, double mdLLegadaEnvio, double mdLLegadaPostales, double mdLLegadaReclamos, double mdLLegadaVenta,
           double mdFinAtencion, double mdFinEnvio, double mdFinPostales, double mdFinReclamos, double mdFinVenta)
        {
            this.mostrarDesde = mostrarDesde;
            this.cantidadIteraciones = cantidadIteraciones;
            this.distribuciones = construirDistribuciones(mdLLegadaAtencion, mdLLegadaEnvio, mdLLegadaPostales, mdLLegadaReclamos, mdLLegadaVenta,
                mdFinAtencion, mdFinEnvio, mdFinPostales, mdFinReclamos, mdFinVenta);
            if (cantidadIteraciones < mostrarDesde + 499)
            {
                resultadosSimulacion = new VectorEstado[cantidadIteraciones - mostrarDesde + 1];
            }
            else
            {
                resultadosSimulacion = new VectorEstado[300];
            }

        }

        private Dictionary<int, Distribucion> construirDistribuciones(double mdLLegadaAtencion, double mdLLegadaEnvio, double mdLLegadaPostales, double mdLLegadaReclamos, double mdLLegadaVenta,
           double mdFinAtencion, double mdFinEnvio, double mdFinPostales, double mdFinReclamos, double mdFinVenta)
        {
            distribuciones = new Dictionary<int, Distribucion>
            {
                { 1, new Exponencial(mdLLegadaAtencion) },
                { 2, new Exponencial(mdLLegadaEnvio) },
                { 3, new Exponencial(mdLLegadaPostales) },
                { 4, new Exponencial(mdLLegadaReclamos) },
                { 5, new Exponencial(mdLLegadaVenta) },
                { 6, new Exponencial(mdFinAtencion) },
                { 7, new Exponencial(mdFinEnvio) },
                { 8, new Exponencial(mdFinPostales) },
                { 9, new Exponencial(mdFinReclamos) },
                { 10, new Exponencial(mdFinVenta) }
            };
            return distribuciones;
        }

        public VectorEstado[] Simular()
        {
            // Fila Inicial
            var filaActual = new VectorEstado(distribuciones);
            int indice = 0;

            // Simulamos

            for (int i = 0; i < cantidadIteraciones; i++)
            {
                if ((i >= mostrarDesde - 1) && (i < mostrarDesde + 299))
                {
                    desdeActivo = true;
                    resultadosSimulacion[indice] = new VectorEstado(filaActual, distribuciones, true);
                    indice++;
                }
                else if (i > mostrarDesde + 299 && desdeActivo)
                {
                    filaActual = new VectorEstado(filaActual, distribuciones, true);
                    desdeActivo = false;
                }
                if (i + 1 == cantidadIteraciones)
                {
                    break;
                }
                // Determinación del Próximo Evento
                var proximo = filaActual.determinarSiguienteEvento();
                var siguienteEvento = proximo.Item1;
                var nuevoReloj = proximo.Item2;

                switch (siguienteEvento)
                {
                    case "Llegada Cliente Atencion":
                        filaActual = Llegada_atencion(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Llegada Cliente Envios":
                        filaActual = LLegada_envios(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Llegada Cliente Postales":
                        filaActual = Llegada_postales(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Llegada Cliente Reclamos":
                        filaActual = Llegada_reclamos(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Llegada Cliente Venta":
                        filaActual = Llegada_venta(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Fin atencion":
                        filaActual = Fin_atencion_atencion(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Fin envios":
                        filaActual = Fin_atencion_envio(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Fin postales":
                        filaActual = fin_Atencion_Postales(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Fin reclamos":
                        filaActual = Fin_atencion_reclamos(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    case "Fin venta":
                        filaActual = Fin_atencion_venta(filaActual, nuevoReloj, siguienteEvento);
                        break;
                    default:
                        break;
                }

            }
            metricasFinales = filaActual.Metricas;
            return resultadosSimulacion;
        }

        private VectorEstado Llegada_atencion(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            var nuevaLlegada = new Llegada_atencion(distribuciones[1], nuevoReloj);
            Cliente cliente = new Cliente();

            if (filaActual.Empleado_atencion.estaLibre() && filaActual.Empleado_atencion.hayCola())
            {
                cliente.Estado = "SA";
                nuevaFila.Empleado_atencion.Estado = "O";
                nuevaFila.Fin_atencion_atencion = new Fin_atencion_atencion(nuevoReloj);
            }
            else
            {
                cliente.Estado = "EA";
                nuevaFila.Empleado_atencion.Cola++;
            }
            nuevaFila.ListaClientes.Add(cliente);
            nuevaFila.Llegada_atencion = nuevaLlegada;
            return nuevaFila;
        }
        private VectorEstado LLegada_envios(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            var nuevaLlegada = new LLegada_envios(distribuciones[2], nuevoReloj);
            Cliente cliente = new Cliente();

            if (filaActual.Empleado_Envio.estaLibre() && filaActual.Empleado_Envio.hayCola())
            {
                cliente.Estado = "SA";
                nuevaFila.Empleado_Envio.Estado = "O";
                nuevaFila.Fin_atencion_envio = new Fin_atencion_envio(nuevoReloj);
            }
            else
            {
                cliente.Estado = "EA";
                nuevaFila.Empleado_Envio.Cola++;
            }
            nuevaFila.ListaClientes.Add(cliente);
            nuevaFila.LLegada_envios = nuevaLlegada;
            return nuevaFila;
        }
        private VectorEstado Llegada_postales(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            var nuevaLlegada = new Llegada_postales(distribuciones[3], nuevoReloj);
            Cliente cliente = new Cliente();

            if (filaActual.Empleado_Postales.estaLibre() && filaActual.Empleado_Postales.hayCola())
            {
                cliente.Estado = "SA";
                nuevaFila.Empleado_Postales.Estado = "O";
                nuevaFila.fin_Atencion_Postales = new Fin_atencion_postales(nuevoReloj);
            }
            else
            {
                cliente.Estado = "EA";
                nuevaFila.Empleado_atencion.Cola++;
            }
            nuevaFila.ListaClientes.Add(cliente);
            nuevaFila.Llegada_postales = nuevaLlegada;
            return nuevaFila;
        }
        private VectorEstado Llegada_reclamos(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            var nuevaLlegada = new Llegada_reclamos(distribuciones[4], nuevoReloj);
            Cliente cliente = new Cliente();

            if (filaActual.Empleado_Reclamos.estaLibre() && filaActual.Empleado_Reclamos.hayCola())
            {
                cliente.Estado = "SA";
                nuevaFila.Empleado_Reclamos.Estado = "O";
                nuevaFila.fin_Atencion_Reclamos = new Fin_atencion_reclamos(nuevoReloj);
            }
            else
            {
                cliente.Estado = "EA";
                nuevaFila.Empleado_Reclamos.Cola++;
            }
            nuevaFila.ListaClientes.Add(cliente);
            nuevaFila.Llegada_reclamos = nuevaLlegada;
            return nuevaFila;
        }
        private VectorEstado Llegada_venta(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            var nuevaLlegada = new Llegada_venta(distribuciones[5], nuevoReloj);
            Cliente cliente = new Cliente();

            if (filaActual.Empleado_Venta.estaLibre() && filaActual.Empleado_Venta.hayCola())
            {
                cliente.Estado = "SA";
                nuevaFila.Empleado_Venta.Estado = "O";
                nuevaFila.fin_Atencion_Venta = new Fin_atencion_venta(nuevoReloj);
            }
            else
            {
                cliente.Estado = "EA";
                nuevaFila.Empleado_Venta.Cola++;
            }
            nuevaFila.ListaClientes.Add(cliente);
            nuevaFila.Llegada_Venta = nuevaLlegada;
            return nuevaFila;
        }

        private VectorEstado Fin_atencion_atencion(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            int nroCliente = buscarClienteAtendido(filaActual);
            nuevaFila.ListaClientes[nroCliente].Estado = "Muerto";
            if (filaActual.Empleado_atencion.Cola > 0)
            {
                int proximoCliente = buscarSiguienteCliente(filaActual);
                nuevaFila.ListaClientes[proximoCliente].Estado = "SA";
                nuevaFila.Empleado_atencion.Cola--;
                Fin_atencion_atencion nuevoFin = new Fin_atencion_atencion(nuevoReloj);
                nuevaFila.Fin_atencion_atencion = nuevoFin;
            }
            else
            {
                nuevaFila.Empleado_atencion.Estado = "Libre";
                nuevaFila.Fin_atencion_atencion.Hora = 0;
            }
            nuevaFila.Empleado_atencion.cantidadClientes++;
            nuevaFila.Metricas.cantidadTotalClientes++;
            return nuevaFila;
        }
        private VectorEstado Fin_atencion_envio(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            int nroCliente = buscarClienteAtendido(filaActual);
            nuevaFila.ListaClientes[nroCliente].Estado = "Muerto";
            if (filaActual.Empleado_Envio.Cola > 0)
            {
                int proximoCliente = buscarSiguienteCliente(filaActual);
                nuevaFila.ListaClientes[proximoCliente].Estado = "SA";
                nuevaFila.Empleado_Envio.Cola--;
                Fin_atencion_envio nuevoFin = new Fin_atencion_envio(nuevoReloj);
                nuevaFila.Fin_atencion_envio = nuevoFin;
            }
            else
            {
                nuevaFila.Empleado_Envio.Estado = "Libre";
                nuevaFila.Fin_atencion_envio.Hora = 0;
            }
            nuevaFila.Empleado_Envio.cantidadClientes++;
            nuevaFila.Metricas.cantidadTotalClientes++;
            return nuevaFila;
        }
        private VectorEstado fin_Atencion_Postales(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            int nroCliente = buscarClienteAtendido(filaActual);
            nuevaFila.ListaClientes[nroCliente].Estado = "Muerto";
            if (filaActual.Empleado_Postales.Cola > 0)
            {
                int proximoCliente = buscarSiguienteCliente(filaActual);
                nuevaFila.ListaClientes[proximoCliente].Estado = "S";
                nuevaFila.Empleado_Postales.Cola--;
                Fin_atencion_postales nuevoFin = new Fin_atencion_postales(nuevoReloj);
                nuevaFila.fin_Atencion_Postales = nuevoFin;
            }
            else
            {
                nuevaFila.Empleado_Postales.Estado = "L";
                nuevaFila.fin_Atencion_Postales.Hora = 0;
            }
            nuevaFila.Empleado_Postales.cantidadClientes++;
            nuevaFila.Metricas.cantidadTotalClientes++;
            return nuevaFila;
        }
        private VectorEstado Fin_atencion_reclamos(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            int nroCliente = buscarClienteAtendido(filaActual);
            nuevaFila.ListaClientes[nroCliente].Estado = "Muerto";
            if (filaActual.Empleado_Reclamos.Cola > 0)
            {
                int proximoCliente = buscarSiguienteCliente(filaActual);
                nuevaFila.ListaClientes[proximoCliente].Estado = "S";
                nuevaFila.Empleado_Reclamos.Cola--;
                Fin_atencion_reclamos nuevoFin = new Fin_atencion_reclamos(nuevoReloj);
                nuevaFila.fin_Atencion_Reclamos = nuevoFin;
            }
            else
            {
                nuevaFila.Empleado_Reclamos.Estado = "L";
                nuevaFila.fin_Atencion_Reclamos.Hora = 0;
            }
           
            nuevaFila.Metricas.cantidadTotalClientes++;
            return nuevaFila;
        }
        private VectorEstado Fin_atencion_venta(VectorEstado filaActual, double nuevoReloj, string siguienteEvento)
        {
            VectorEstado nuevaFila;
            if (desdeActivo)
            {
                nuevaFila = new VectorEstado(filaActual, distribuciones);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.Evento = siguienteEvento;
            nuevaFila.Reloj = nuevoReloj;
            actualizarEstadisticas(filaActual, nuevaFila);
            int nroCliente = buscarClienteAtendido(filaActual);
            nuevaFila.ListaClientes[nroCliente].Estado = "Muerto";
            if (filaActual.Empleado_Venta.Cola > 0)
            {
                int proximoCliente = buscarSiguienteCliente(filaActual);
                nuevaFila.ListaClientes[proximoCliente].Estado = "S";
                nuevaFila.Empleado_Venta.Cola--;
                Fin_atencion_venta nuevoFin = new Fin_atencion_venta(nuevoReloj);
                nuevaFila.fin_Atencion_Venta = nuevoFin;
            }
            else
            {
                nuevaFila.Empleado_Venta.Estado = "L";
                nuevaFila.fin_Atencion_Venta.Hora = 0;
            }
            nuevaFila.Metricas.cantidadTotalClientes++;
            return nuevaFila;
        }
        private int buscarSiguienteCliente(VectorEstado filaActual)
        {
            for (int i = 0; i < filaActual.ListaClientes.Count; i++)
            {
                if (filaActual.ListaClientes[i].Estado.Equals("EA"))
                {
                    return i;
                }
            }
            return -1;
        }

        private int buscarClienteAtendido(VectorEstado ve)
        {
            for (int i = 0; i < ve.ListaClientes.Count; i++)
            {
                if (ve.ListaClientes[i].Estado.Equals("SA"))
                {
                    return i;
                }
            }
            return -1;
        }

        public void actualizarEstadisticas(VectorEstado filaActual, VectorEstado nuevaFila)
        {
            //calculos
        }
        
    
    }
}
