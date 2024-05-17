using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM_G6
{
    public partial class SimMontecarlo : Form
    {
        public SimMontecarlo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Funcionalidad del boton inciar simulacion, llama al metodo para crear la tabla de informacion
        /// </summary>
        /// 
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            List<double> probTipo = new List<double> { 0.35, 0.4, 0.25 };
            List<double> probAlta = new List<double> { 0.05, 0.1, 0.25, 0.3, 0.2, 0.1 };
            List<double> probMedia = new List<double> { 0.1, 0.2, 0.3, 0.25, 0.1, 0.05 };
            List<double> probBaja = new List<double> { 0.15, 0.25, 0.35, 0.15, 0.05, 0.05 };
            List<string> tipoDemanda = new List<string> { "Alta", "Media", "Baja" };
            List<double> cantDemanda = new List<double> { 36, 48, 60, 72, 84, 96 };

            DataTable probTipoDemanda = generarTablaProbabilidadesTipo(probTipo, tipoDemanda);
            DataTable probDemAlta = generarTablaProbabilidades(probAlta, cantDemanda);
            DataTable probDemMedia = generarTablaProbabilidades(probMedia, cantDemanda);
            DataTable probDemBaja = generarTablaProbabilidades(probBaja, cantDemanda);

            int n = 120;

            limpiarCampos();
            generarSimulacion(n, probTipoDemanda, probDemAlta, probDemMedia, probDemBaja);

        }


        //generacion de simulacion 
        private void generarSimulacion(int n, DataTable probTipoDemanda, DataTable probDemAlta, DataTable probDemMedia, DataTable probDemBaja)
        {

            // Contadores y Acumuladores
            double sobrantesAC = 0;
            double perdidasAC = 0;
            double optimoAC = 0;
            double ganTotalAc = 0;

            // Generar dias
            for (int d = 1; d <= n; d++)
            {
                Random rndTD = new Random();
                double rndTipoDemanda = rndTD.NextDouble();
                Random rndDem = new Random();
                double rndDemanda = rndDem.NextDouble();


                int stockFacturas = int.Parse(txtStock.Text.ToString());
                if (stockFacturas % 12 != 0)
                {
                    MessageBox.Show("Debe ingresar un número de facturas válido (debe corresponder a x cantidad de docenas)");
                    limpiarCampos();
                    break;
                }
                double sobrantes = 0;
                double perdidas = 0;
                double optimo = 0;
                double demandaDia = 0;

                double gananVenta = 0;
                double costoProduc = 0;
                double gananSobrante = 0;
                double costoFaltante = 0;
                double ganTotal = 0;

                string tipoDemanda = BuscarTipoDemanda(probTipoDemanda, rndTipoDemanda);

                if (tipoDemanda == "Alta")
                {
                    demandaDia = BuscarDemanda(probDemAlta, rndDemanda);
                    if (stockFacturas > demandaDia)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        sobrantes = stockFacturas - demandaDia;
                        gananSobrante = 0.08 * sobrantes;
                        costoFaltante = 0;

                    }
                    if (demandaDia > stockFacturas)
                    {
                        gananVenta = stockFacturas * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = demandaDia - stockFacturas;
                        gananSobrante = 0;
                        costoFaltante = 0.1 * perdidas;
                    }
                    if (demandaDia == stockFacturas)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = 0;
                        gananSobrante = 0;
                        costoFaltante = 0;
                    }
                    optimo = stockFacturas - sobrantes + perdidas;
                    ganTotal = gananVenta - costoProduc + gananSobrante - costoFaltante;
                }
                else if (tipoDemanda == "Media")
                {
                    demandaDia = BuscarDemanda(probDemMedia, rndDemanda);
                    if (stockFacturas > demandaDia)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        sobrantes = stockFacturas - demandaDia;
                        gananSobrante = 0.08 * sobrantes;
                        costoFaltante = 0;
                    }
                    if (demandaDia > stockFacturas)
                    {
                        gananVenta = stockFacturas * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = demandaDia - stockFacturas;
                        gananSobrante = 0;
                        costoFaltante = 0.1 * perdidas;
                    }
                    if (demandaDia == stockFacturas)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = 0;
                        gananSobrante = 0;
                        costoFaltante = 0;
                    }
                    optimo = stockFacturas - sobrantes + perdidas;
                    ganTotal = gananVenta - costoProduc + gananSobrante - costoFaltante;
                }
                else
                {
                    demandaDia = BuscarDemanda(probDemBaja, rndDemanda);
                    if (stockFacturas > demandaDia)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        sobrantes = stockFacturas - demandaDia;
                        gananSobrante = 0.08 * sobrantes;
                        costoFaltante = 0;
                    }
                    if (demandaDia > stockFacturas)
                    {
                        gananVenta = stockFacturas * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = demandaDia - stockFacturas;
                        gananSobrante = 0;
                        costoFaltante = 0.1 * perdidas;
                    }
                    if (demandaDia == stockFacturas)
                    {
                        gananVenta = demandaDia * 0.25;
                        costoProduc = stockFacturas * 0.15;
                        perdidas = 0;
                        gananSobrante = 0;
                        costoFaltante = 0;
                    }
                    optimo = stockFacturas - sobrantes + perdidas;
                    ganTotal = gananVenta - costoProduc + gananSobrante - costoFaltante;
                }
                sobrantesAC += sobrantes;
                perdidasAC += perdidas;
                optimoAC += optimo;
                ganTotalAc += ganTotal;


                grdSimulacion.Rows.Add(d, stockFacturas, TruncarNumero(rndTipoDemanda, 2), tipoDemanda, TruncarNumero(rndDemanda, 2), demandaDia, TruncarNumero(costoProduc, 2), TruncarNumero(gananVenta, 2), sobrantes, sobrantesAC, TruncarNumero(gananSobrante, 2), perdidas, perdidasAC, TruncarNumero(costoFaltante, 2), optimo, optimoAC, TruncarNumero(ganTotal, 2), TruncarNumero(ganTotalAc, 2));

            }

            //promedio optimo para 120 dias, cantidad de facturas óptima a producir por día
            txtPromOptimo.Text = (optimoAC / 120).ToString();
            // devuelve el último valor de la gananciaAC / cant de días = ganancia promedio por día con la oferta seleccionada
            txtGananciaProm.Text = TruncarNumero((ganTotalAc / 120), 2).ToString();

        }

        private string BuscarTipoDemanda(DataTable probTipoDemanda, double rndTipoDemanda)
        {
            string tipoDem = "";
            foreach (DataRow prob in probTipoDemanda.Rows)
            {
                if (rndTipoDemanda >= Convert.ToDouble(prob["LI"]) && rndTipoDemanda < Convert.ToDouble(prob["LS"]))
                {
                    tipoDem = (string)prob["Tipo"];
                }
            }
            return tipoDem;
        }

        private double BuscarDemanda(DataTable probabilidades, double rndDemanda)
        {
            double demanda = 0;
            foreach (DataRow prob in probabilidades.Rows)
            {
                if (rndDemanda >= Convert.ToDouble(prob["LI"]) && rndDemanda < Convert.ToDouble(prob["LS"]))
                {
                    demanda = ((double)prob["Demanda"]);

                    break;
                }
            }
            return demanda;
        }

        public DataTable generarTablaProbabilidadesTipo(List<double> probTipo, List<string> tipoDemanda)
        {
            DataTable valores = new DataTable();

            //valores.Columns.Add("DEMANDA", typeof(int));
            valores.Columns.Add("PROBABILIDAD", typeof(double));
            valores.Columns.Add("LI", typeof(double));
            valores.Columns.Add("LS", typeof(double));
            valores.Columns.Add("Tipo", typeof(string));

            //List<int> demandas = new List<int> { 1, 2, 5, 6, 7, 8, 10 };
            int i = 0;
            double li = 0;
            double ls = 0;

            for (int cantDemandas = 0; i < tipoDemanda.Count; cantDemandas++)
            {
                if (cantDemandas == (i - 1)) //es ultima demanda
                {
                    valores.Rows.Add(probTipo[i], li, 0.99999, tipoDemanda[i]);
                }
                else
                {
                    ls += probTipo[i];
                    valores.Rows.Add(probTipo[i], li, ls, tipoDemanda[i]);
                    li = ls;
                }
                i++;
            }

            return valores;
        }

        public DataTable generarTablaProbabilidades(List<double> probabilidades, List<double> cantDemanda)
        {
            DataTable valores = new DataTable();

            valores.Columns.Add("PROBABILIDAD", typeof(double));
            valores.Columns.Add("LI", typeof(double));
            valores.Columns.Add("LS", typeof(double));
            valores.Columns.Add("Demanda", typeof(double));

            int i = 0;
            double li = 0;
            double ls = 0;
            double cantDemandas = cantDemanda.Count;

            foreach (int demanda in cantDemanda)
            {
                if (cantDemandas == (i - 1)) //es ultima demanda
                {
                    valores.Rows.Add(probabilidades[i], li, 0.99999, cantDemanda[i]);
                }
                else
                {
                    ls += probabilidades[i];
                    valores.Rows.Add(probabilidades[i], li, ls, cantDemanda[i]);
                    li = ls;
                }
                i++;
            }

            return valores;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            grdSimulacion.Rows.Clear();
            txtPromOptimo.Text = "";
            txtGananciaProm.Text = "";
        }

        private double TruncarNumero(double numero, int decimales)
        {
            double factor = Math.Pow(10, decimales);
            return Math.Truncate(numero * factor) / factor;
        }
    }
}
