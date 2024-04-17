using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }
                else if (rbExponencial.Checked)
                {
                    if ((txtLambda.Text == "" && txtMedia.Text == "") || (txtLambda.Text != "" && txtMedia.Text != ""))
                    {
                        MessageBox.Show("Debe completar el dato Lambda o Media", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbNormal.Checked)
                {
                    if (txtDesv.Text == "" || txtMedia.Text == "")
                    {
                        MessageBox.Show("Debe completar el dato Media y desviacion", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



            }
        }

        private void generarAleatoriosUniforme()
        {

        }
        private void generarAleatoriosNormal()
        {

        }
        private void generarAleatoriosExponencial()
        {

        }
    }
}
