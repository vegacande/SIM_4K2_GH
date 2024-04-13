using System.Windows.Forms;

namespace TP01_4K2_GH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Formularios.Generador generador = new Formularios.Generador();
            generador.ShowDialog();
            this.Close();
        }
    }
}