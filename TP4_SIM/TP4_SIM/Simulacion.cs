using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TP4_SIM.Objetos;

namespace TP4_SIM
{
    public partial class Simulacion : Form
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            bool resultado = validarCampos();
            if (resultado)
            {
                simular();
            }
            else
            {
                MessageBox.Show("Error, parametros invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            //agregar validaciones
            return true;
        }

        private void simular()
        {
            dgvColas.Rows.Clear();
            int cantFilas = int.Parse(txtCantFilas.Text);
            // Valores de media (dist. exponencial) de los eventos 
            double mdLLegadaEnvio = double.Parse(txtLlegadaPaquete.Text);
            double mdFinEnvio = double.Parse(txtFinPaquete.Text);
            double mediaLlegadaReclamo = double.Parse(txtLlegadaReclamo.Text);
            double mediaFinReclamo = double.Parse(txtFinReclamo.Text);
            double mediaLlegadaVenta = double.Parse(txtLlegadaVenta.Text);
            double mediaFinVenta = double.Parse(txtFinVenta.Text);
            double mediaLlegadaAE = double.Parse(txtLlegadaAtencion.Text);
            double mediaFinAE = double.Parse(txtFinAtencion.Text);
            double mediaLlegadaPostales = double.Parse(txtLlegadaPostales.Text);
            double mediaFinPostales = double.Parse(txtFinPostales.Text);

            // Nro de fila a partir de la que sea desea visualizar
            int mostrarDesde = int.Parse(txtPrimeraFila.Text);

            // Creamos nuestro gestor
            GestorColas gestorColas = new GestorColas(mostrarDesde, cantFilas, mediaLlegadaAE, mdLLegadaEnvio, mediaLlegadaPostales, mediaLlegadaReclamo, mediaLlegadaVenta,
                mediaFinAE, mdFinEnvio, mediaFinPostales, mediaFinReclamo, mediaFinVenta);
            
            // Simulamos
            VectorEstado[] resultadosSimulacion = gestorColas.Simular();
            CargarSimulacion(resultadosSimulacion);
          
        }
        public void CargarSimulacion(VectorEstado[] resultadosSimulacion)
        {
            dgvColas.SuspendLayout();
            dgvColas.EnableHeadersVisualStyles = false;
            DoubleBuffered = false;

            // Cargamos las columnas
            dgvColas.Columns.Add("Evento", "Evento");
            dgvColas.Columns.Add("Reloj", "Reloj (min)");

            dgvColas.Columns.Add("RND_llegada_atencion", "RND");
            dgvColas.Columns.Add("Tiempo_llegada_atencion", "Tiempo de Llegada Atencion");
            dgvColas.Columns.Add("Hora_llegada_atencion", "Proxima Llegada");

            dgvColas.Columns.Add("RND_llegada_envios", "RND");
            dgvColas.Columns.Add("Tiempo_llegada_envios", "Tiempo de Llegada envios");
            dgvColas.Columns.Add("Hora_llegada_envios", "Proxima Llegada");

            dgvColas.Columns.Add("RND_llegada_postales", "RND");
            dgvColas.Columns.Add("Tiempo_llegada_postales", "Tiempo de Llegada postales");
            dgvColas.Columns.Add("Hora_llegada_postales", "Proxima Llegada");

            dgvColas.Columns.Add("RND_llegada_reclamos", "RND");
            dgvColas.Columns.Add("Tiempo_llegada_reclamos", "Tiempo de Llegada reclamos");
            dgvColas.Columns.Add("Hora_llegada_reclamos", "Proxima Llegada");

            dgvColas.Columns.Add("RND_llegada_venta", "RND");
            dgvColas.Columns.Add("Tiempo_llegada_envios", "Tiempo de Llegada venta");
            dgvColas.Columns.Add("Hora_llegada_venta", "Proxima Llegada");

            dgvColas.Columns.Add("RND_Atencion", "RND");
            dgvColas.Columns.Add("Tiempo_Atencion", "Tiempo de Atencion");
            dgvColas.Columns.Add("Fin_Atencion", "Fin de Atencion");

            //faltan fin y empleados

            dgvColas.Columns.Add("Estado_EmpleadoA", "Estado EmpleadoA");
            dgvColas.Columns.Add("Cola_EmpleadoA", "Cola EmpleadoA");
            dgvColas.Columns.Add("Cantidad_ClientesA", "Cant. ClientesA");

            dgvColas.Columns.Add("Cantidad_Total_Clientes", "Cantidad Total Clientes");

            int i = 1;
            var contador = 0;
            bool overflow = false;

            foreach (Cliente c in resultadosSimulacion[resultadosSimulacion.Length - 1].ListaClientes)
            {
                try
                {
                    dgvColas.Columns.Add("estado_CA" + i.ToString(), "Estado Cliente" + i.ToString());
                    i++;
                    contador++;
                }
                catch (Exception ex)
                {
                    overflow = true;
                    dgvColas.Columns.Remove("estado_CA" + i.ToString());
                }
                if (overflow)
                {
                    break;
                }
            }
            i = 1;
            if (!overflow)
            {
                foreach (Cliente c in resultadosSimulacion[resultadosSimulacion.Length - 1].ListaClientes)
                {
                    try
                    {
                        dgvColas.Columns.Add("estado_CA" + i.ToString(), "Estado Cliente " + i.ToString());
                        i++;
                        contador++;
                    }
                    catch (Exception ex)
                    {
                        overflow = true;
                        dgvColas.Columns.Remove("estado_CA" + i.ToString());
                    }
                    if (overflow)
                    {
                        break;
                    }
                }
            }
            dgvColas.Scroll += new ScrollEventHandler(dgvColas_Scroll);

            var cantidadClientesTotales = resultadosSimulacion[resultadosSimulacion.Length - 1].ListaClientes.Count();
            foreach (VectorEstado ve in resultadosSimulacion)
            {
                dgvColas.Rows.Add(ve.ToLista(cantidadClientesTotales, contador));
            }
            dgvColas.ResumeLayout(false);


        }

        private void dgvColas_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dgvColas.DisplayRectangle;
            rtHeader.Height = this.dgvColas.ColumnHeadersHeight / 2;
            this.dgvColas.Invalidate(rtHeader);
            this.dgvColas.AllowUserToOrderColumns = false;
        }


    }
} 
