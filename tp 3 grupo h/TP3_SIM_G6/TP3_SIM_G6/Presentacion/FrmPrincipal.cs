namespace TP3_SIM_G6
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            SimMontecarlo simMontecarlo = new SimMontecarlo();
            simMontecarlo.ShowDialog();
            this.Close();
        }
    }
}