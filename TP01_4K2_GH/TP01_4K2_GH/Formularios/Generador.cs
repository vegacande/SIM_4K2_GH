﻿using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP01_4K2_GH.Formularios
{
    public partial class Generador : Form
    {
        public Generador()
        {
            InitializeComponent();
            rb10.Checked = true;
            rbNormal.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtDesv.Text = "";
            txtLambda.Text = "";
            txtMedia.Text = "";
            txtTamañoMuestra.Text = "";
            grillaAleatorios.Rows.Clear();
            grillaFrecuencias.Rows.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtTamañoMuestra.Text == "" || int.Parse(txtTamañoMuestra.Text.ToString()) > 1000000 || int.Parse(txtTamañoMuestra.Text.ToString()) < 0)
            {
                MessageBox.Show("Ingrese un tamaño de muestra válido. Debe ser mayor a cero y menor igual a 1.000.000");
            }
            else
            {
                if (rbUniforme.Checked)
                {
                    if (txtA.Text == "" || txtB.Text == "")
                    {
                        MessageBox.Show("Debe completar los campos A y B");
                    }
                    else if (double.Parse(txtA.Text.ToString()) > double.Parse(txtB.Text.ToString()))
                    {
                        MessageBox.Show("El valor de A debe ser menor a B", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else generarAleatoriosUniforme();
                }

                else if (rbExponencial.Checked)
                {
                    if ((txtLambda.Text == "" && txtMedia.Text == "") || (txtLambda.Text != "" && txtMedia.Text != ""))
                    {
                        MessageBox.Show("Debe completar el dato Lambda o Media", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else generarAleatoriosExponencial();
                }
                else if (rbNormal.Checked)
                {
                    if (txtDesv.Text == "" || txtMedia.Text == "")
                    {
                        MessageBox.Show("Debe completar el dato Media y desviacion", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else generarAleatoriosNormal();
                }



            }
        }

        /// <summary>
        /// Trunca el numero a 4 decimales
        /// </summary>
        private double truncarNumero(double numero)
        {
            return Math.Truncate(numero * 10000) / 10000;
        }

        /// <summary>
        /// Calcula las frecuencias observadas por intervalos
        /// </summary>
        /// <param name="lista">lista de numeros aleatorios</param>
        /// <param name="cantIntervalos">cantidad de intervalos indicado</param>
        /// <returns>tabla con valores: Nro Intervalo, Limite inferior, Limite superior, Frecuencia Observada</returns>
        private DataTable calcularFrecuenciaObservada(List<double> lista, int cantIntervalos)
        {
            double maximo = lista.Max();
            double minimo = lista.Min();
            double rango = maximo - minimo;
            double amplitud = rango / cantIntervalos;

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Intervalo", typeof(int));
            tabla.Columns.Add("LI", typeof(double));
            tabla.Columns.Add("LS", typeof(double));
            tabla.Columns.Add("FO", typeof(int));
            double limInf = minimo;
            double limSup = 0;

            for (int i = 0; i < cantIntervalos; i++)
            {
                if (i == 0)
                {
                    limSup = minimo + amplitud;
                }
                if (i == cantIntervalos)
                {
                    limSup = maximo;
                }
                tabla.Rows.Add(i + 1, limInf, limSup, 0);
                limInf = limSup;
                limSup = limSup + amplitud;
            }

            foreach (double num in lista)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (num >= Convert.ToDouble(tabla.Rows[i]["LI"]) && num < Convert.ToDouble(tabla.Rows[i]["LS"]))
                    {
                        tabla.Rows[i]["FO"] = Convert.ToInt32(tabla.Rows[i]["FO"]) + 1;
                        break;
                    }
                    if (num == maximo)
                    {
                        tabla.Rows[tabla.Rows.Count - 1]["FO"] = Convert.ToInt32(tabla.Rows[tabla.Rows.Count - 1]["FO"]) + 1;
                        break;
                    }
                }
            }
            return tabla;
        }

        /// <summary>
        /// Genera los numeros aleatorios para la distribucion Uniforme y los muestra en la grilla
        /// </summary>
        private void generarAleatoriosUniforme()
        {
            grillaAleatorios.Rows.Clear();
            List<double> lista = new List<double>();

            // Se genera con funcion Random propio del lenguaje - genera del (0,1]
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(txtTamañoMuestra.Text.ToString()); i++)
            {
                double random = randomDoubleRandom(rnd);
                // Para generar aleatorio en Uniforme: X=A+RND(B-A)
                double num = truncarNumero(double.Parse(txtA.Text.ToString()) + (random * (double.Parse(txtB.Text.ToString()) - double.Parse(txtA.Text.ToString()))));
                lista.Add(num);
                grillaAleatorios.Rows.Add(i + 1, num);
                // Se actualiza el valor de la barra de progreso para mostrar avance
                //prbCargaNumeros.Value = i + 1;
            }
            generarTablaFrecuencias(lista);
        }
        
        /// <summary>
        /// Genera los numeros aleatorios para la distribucion Exponencial y los muestra en la grilla
        /// </summary>
      
        private void generarAleatoriosExponencial()
        {
            grillaAleatorios.Rows.Clear();
            List<double> lista = new List<double>();
            double lambda;
            if (txtLambda.Text == "") lambda = 1 / double.Parse(txtMedia.Text.ToString());
            else lambda = double.Parse(txtLambda.Text.ToString());

            Random rnd = new Random();
            for (int i = 0; i < int.Parse(txtTamañoMuestra.Text.ToString()); i++)
            {
                double random = randomDoubleRandom(rnd);
                // Para generar aleatorio en Exponencial: X= -1/LAMBDA * ln(1-RND)
                double num = truncarNumero((-1 / lambda) * (Math.Log(1 - random)));
                lista.Add(num);
                grillaAleatorios.Rows.Add(i + 1, num);
                //prbCargaNumeros.Value = i + 1;
            }
            generarTablaFrecuencias(lista);
        }

        /// <summary>
        /// Genera los numeros aleatorios para la distribucion Normal y los muestra en la grilla
        /// </summary>
        private void generarAleatoriosNormal()
        {
            grillaAleatorios.Rows.Clear();
            List<double> lista = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < int.Parse(txtTamañoMuestra.Text.ToString()); i++)
            {
                // Para generar aleatorio en Normal: X = ((RAIZ(-2 * ln(RND1)) * cos(2*PI*RND2)) * DESVIACION) + MEDIA
                double random1 = randomDoubleRandom(rnd);
                double random2 = randomDoubleRandom(rnd);
                double num = truncarNumero(((((Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2))) * double.Parse(txtDesv.Text.ToString())) + double.Parse(txtMedia.Text.ToString())));
                lista.Add(num);
                grillaAleatorios.Rows.Add(i + 1, num);
                //prbCargaNumeros.Value = i + 1;
            }
            generarTablaFrecuencias(lista);
        }

        /// <summary>
        /// Calculo de frencuencias
        /// </summary>
        /// <param name="lista">lista de numeros random generados</param>
        private void generarTablaFrecuencias(List<double> lista)
        {
            grillaFrecuencias.Rows.Clear();
            int cantIntervalos = 10;
            if (rb12.Checked) cantIntervalos = 12;
            else if (rb16.Checked) cantIntervalos = 16;
            else if (rb23.Checked) cantIntervalos = 23;
            double frecuenciaEsp = 0;
            DataTable tablaFO = calcularFrecuenciaObservada(lista, cantIntervalos);
            double totalFrecObs = 0;
            double totalFrecEsp = 0;

            for (int i = 0; i < cantIntervalos; i++)
            {
                if (rbUniforme.Checked) //Uniforme
                {
                    frecuenciaEsp = double.Parse(txtTamañoMuestra.Text.ToString()) / cantIntervalos;
                }
                else if (rbExponencial.Checked) //Exponencial
                {
                    //si el usuario ingresa con la media se calcula lambda
                    double lambda = 0;
                    if (txtLambda.Text == "") lambda = 1 / double.Parse(txtMedia.Text.ToString());
                    else lambda = double.Parse(txtLambda.Text.ToString());

                    //calculo frecuencia esperada
                    double expSup = 1 - Math.Exp(Convert.ToDouble(tablaFO.Rows[i]["LS"]) * (-lambda));
                    double expInf = 1 - Math.Exp(Convert.ToDouble(tablaFO.Rows[i]["LI"]) * (-lambda));
                    int N = int.Parse(txtTamañoMuestra.Text.ToString());
                    frecuenciaEsp = (expSup - expInf) * N;
                }
                else if (rbNormal.Checked) //Normal
                {
                    int N = int.Parse(txtTamañoMuestra.Text.ToString());
                    //calculo de la frecuencia esperada para cada limite
                    double NormalSup = calcularFrecuenciaEsperadaNormal(Convert.ToDouble(tablaFO.Rows[i]["LS"]));
                    double NormalInf = calcularFrecuenciaEsperadaNormal(Convert.ToDouble(tablaFO.Rows[i]["LI"]));
                    //calculo de la FE final para cada intervalo
                    frecuenciaEsp = (NormalSup - NormalInf) * N;
                }

                totalFrecObs += truncarNumero(Convert.ToDouble(tablaFO.Rows[i]["FO"]));
                totalFrecEsp += frecuenciaEsp;
                grillaFrecuencias.Rows.Add(truncarNumero(Convert.ToDouble(tablaFO.Rows[i]["Intervalo"])), truncarNumero(Convert.ToDouble(tablaFO.Rows[i]["LI"])), truncarNumero(Convert.ToDouble(tablaFO.Rows[i]["LS"])), truncarNumero(Convert.ToDouble(tablaFO.Rows[i]["FO"])), truncarNumero(frecuenciaEsp));
            }
            grillaFrecuencias.Rows.Add("", "", "", truncarNumero(totalFrecObs), truncarNumero(totalFrecEsp));
            generarHistograma(tablaFO);
        }
        /// <summary>
        /// Calculo de la frecuencia esperada con biblioteca Math.Numerics
        /// </summary>
        /// <param name="lim">limite considerado para el calculo</param>
        /// <returns>frecuencia esperada de la distribucion normal</returns>
        private double calcularFrecuenciaEsperadaNormal(double lim)
        {
            double media = double.Parse(txtMedia.Text.ToString());
            double des = double.Parse(txtDesv.Text.ToString());
            double res = MathNet.Numerics.ExcelFunctions.NormDist(lim, media, des, true);
            return res;
        }
        /// <summary>
        /// Crea un numero aleatorio de tipo random
        /// </summary>
        private double randomDoubleRandom(Random r)
        {
            double random = r.NextDouble();

            return random;
        }
        /// <summary>
        /// Se genera el histograma en base a los datos recuperados en los pasos anteriores
        /// </summary>
        /// <param name="intervalos">tabla con los datos de: intervalo, LI, LS y FO</param>
        private void generarHistograma(DataTable intervalos)
        {
            double valorMaximo = 0;
            // Se crear una serie para el histograma
            chartFrecuencia.Series.Clear();
            chartFrecuencia.Titles.Clear();
            Series histogramSeries = new Series("FO");
            histogramSeries.ChartType = SeriesChartType.Column;

            // Se agrega los datos del DataTable al histograma
            foreach (DataRow row in intervalos.Rows)
            {
                string categoria = row["Intervalo"].ToString();
                int frecuencia = Convert.ToInt32(row["FO"]);
                histogramSeries.Points.AddXY(categoria, frecuencia);
                valorMaximo = Math.Max(valorMaximo, frecuencia);
            }

            // Agregar la serie al gráfico
            chartFrecuencia.Series.Add(histogramSeries);

            // Personalizar diferentes aspectos del histograma, como el número de barras, el rango de valores, el color de las barras, entre otros.
            histogramSeries.Color = Color.MediumPurple;
            histogramSeries.BorderColor = Color.DarkViolet;

            // Configura el nombre y propiedades del eje X e I en el gráfico
            chartFrecuencia.ChartAreas[0].AxisX.Title = "Intervalos";
            chartFrecuencia.ChartAreas[0].AxisY.Title = "Frecuencias";
            chartFrecuencia.ChartAreas[0].AxisY.Maximum = valorMaximo;

            // Configurar el título del gráfico
            chartFrecuencia.Titles.Add(new Title("Gráfico representativo de la frecuencia observada"));

            // Establecer el ancho de las barras (reduciendo el espacio)
            histogramSeries["PointWidth"] = "1"; // Puedes ajustar este valor según tus preferencias
        }
    }
}
