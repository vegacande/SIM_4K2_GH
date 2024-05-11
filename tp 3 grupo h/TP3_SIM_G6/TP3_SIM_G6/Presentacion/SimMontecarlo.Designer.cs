namespace TP3_SIM_G6
{
    partial class SimMontecarlo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdSimulacion = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtStock = new NumericUpDown();
            lbl = new Label();
            groupBox3 = new GroupBox();
            txtPromOptimo = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btnReiniciar = new Button();
            btnIniciar = new Button();
            prbSimulacion = new ProgressBar();
            dia = new DataGridViewTextBoxColumn();
            Oferta = new DataGridViewTextBoxColumn();
            rndTipo = new DataGridViewTextBoxColumn();
            TipoDemanda = new DataGridViewTextBoxColumn();
            rndDemanda = new DataGridViewTextBoxColumn();
            demanda = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            stockAC = new DataGridViewTextBoxColumn();
            Perdidas = new DataGridViewTextBoxColumn();
            PerdidasAC = new DataGridViewTextBoxColumn();
            Optimo = new DataGridViewTextBoxColumn();
            OptimoAC = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdSimulacion).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // grdSimulacion
            // 
            grdSimulacion.AllowUserToAddRows = false;
            grdSimulacion.AllowUserToDeleteRows = false;
            grdSimulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grdSimulacion.BackgroundColor = Color.Lavender;
            grdSimulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSimulacion.Columns.AddRange(new DataGridViewColumn[] { dia, Oferta, rndTipo, TipoDemanda, rndDemanda, demanda, stock, stockAC, Perdidas, PerdidasAC, Optimo, OptimoAC });
            grdSimulacion.Location = new Point(426, 87);
            grdSimulacion.Margin = new Padding(2, 3, 2, 3);
            grdSimulacion.Name = "grdSimulacion";
            grdSimulacion.ReadOnly = true;
            grdSimulacion.RowHeadersWidth = 51;
            grdSimulacion.RowTemplate.Height = 29;
            grdSimulacion.Size = new Size(1068, 512);
            grdSimulacion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Plum;
            label3.Location = new Point(44, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 26);
            label3.TabIndex = 5;
            label3.Text = "Venta facturas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(lbl);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 77);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(381, 145);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parámetros";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtStock.Location = new Point(216, 71);
            txtStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(71, 23);
            txtStock.TabIndex = 22;
            txtStock.Value = new decimal(new int[] { 96, 0, 0, 0 });
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(46, 71);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(153, 17);
            lbl.TabIndex = 23;
            lbl.Text = "Stock inicial /oferta:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPromOptimo);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(11, 262);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(381, 159);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados (por día)";
            // 
            // txtPromOptimo
            // 
            txtPromOptimo.Enabled = false;
            txtPromOptimo.Location = new Point(123, 89);
            txtPromOptimo.Margin = new Padding(2, 3, 2, 3);
            txtPromOptimo.Name = "txtPromOptimo";
            txtPromOptimo.Size = new Size(127, 24);
            txtPromOptimo.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 69);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 18);
            label12.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 53);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(289, 18);
            label11.TabIndex = 20;
            label11.Text = "Promedio numero optimo de facturas";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Plum;
            btnReiniciar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(57, 558);
            btnReiniciar.Margin = new Padding(2, 3, 2, 3);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(123, 41);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Plum;
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(199, 558);
            btnIniciar.Margin = new Padding(2, 3, 2, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(193, 41);
            btnIniciar.TabIndex = 10;
            btnIniciar.Text = "Iniciar simulación";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // prbSimulacion
            // 
            prbSimulacion.Location = new Point(426, 43);
            prbSimulacion.Margin = new Padding(2);
            prbSimulacion.Name = "prbSimulacion";
            prbSimulacion.Size = new Size(1068, 19);
            prbSimulacion.TabIndex = 13;
            // 
            // dia
            // 
            dia.HeaderText = "Día";
            dia.MinimumWidth = 6;
            dia.Name = "dia";
            dia.ReadOnly = true;
            dia.Width = 58;
            // 
            // Oferta
            // 
            Oferta.HeaderText = "Oferta";
            Oferta.MinimumWidth = 6;
            Oferta.Name = "Oferta";
            Oferta.ReadOnly = true;
            Oferta.Width = 80;
            // 
            // rndTipo
            // 
            rndTipo.HeaderText = "rndTipo";
            rndTipo.Name = "rndTipo";
            rndTipo.ReadOnly = true;
            rndTipo.Width = 90;
            // 
            // TipoDemanda
            // 
            TipoDemanda.HeaderText = "TipoDemanda";
            TipoDemanda.Name = "TipoDemanda";
            TipoDemanda.ReadOnly = true;
            TipoDemanda.Width = 137;
            // 
            // rndDemanda
            // 
            rndDemanda.HeaderText = "rndDemanda";
            rndDemanda.Name = "rndDemanda";
            rndDemanda.ReadOnly = true;
            rndDemanda.Width = 128;
            // 
            // demanda
            // 
            demanda.HeaderText = "Demanda";
            demanda.MinimumWidth = 6;
            demanda.Name = "demanda";
            demanda.ReadOnly = true;
            demanda.Width = 104;
            // 
            // stock
            // 
            stock.HeaderText = "Sobrante";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 101;
            // 
            // stockAC
            // 
            stockAC.HeaderText = "Sobrante AC";
            stockAC.MinimumWidth = 6;
            stockAC.Name = "stockAC";
            stockAC.ReadOnly = true;
            stockAC.Width = 128;
            // 
            // Perdidas
            // 
            Perdidas.HeaderText = "Perdidas";
            Perdidas.MinimumWidth = 6;
            Perdidas.Name = "Perdidas";
            Perdidas.ReadOnly = true;
            Perdidas.Width = 99;
            // 
            // PerdidasAC
            // 
            PerdidasAC.HeaderText = "Perdidas AC";
            PerdidasAC.MinimumWidth = 6;
            PerdidasAC.Name = "PerdidasAC";
            PerdidasAC.ReadOnly = true;
            PerdidasAC.Width = 126;
            // 
            // Optimo
            // 
            Optimo.HeaderText = "Optimo";
            Optimo.MinimumWidth = 6;
            Optimo.Name = "Optimo";
            Optimo.ReadOnly = true;
            Optimo.Width = 88;
            // 
            // OptimoAC
            // 
            OptimoAC.HeaderText = "Optimo AC";
            OptimoAC.MinimumWidth = 6;
            OptimoAC.Name = "OptimoAC";
            OptimoAC.ReadOnly = true;
            OptimoAC.Width = 115;
            // 
            // SimMontecarlo
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1525, 630);
            Controls.Add(prbSimulacion);
            Controls.Add(btnIniciar);
            Controls.Add(btnReiniciar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grdSimulacion);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SimMontecarlo";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)grdSimulacion).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdSimulacion;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Button btnReiniciar;
        private Button btnIniciar;
        private TextBox txtPromOptimo;
        private ProgressBar prbSimulacion;
        private NumericUpDown txtStock;
        private Label lbl;
        private DataGridViewTextBoxColumn dia;
        private DataGridViewTextBoxColumn Oferta;
        private DataGridViewTextBoxColumn rndTipo;
        private DataGridViewTextBoxColumn TipoDemanda;
        private DataGridViewTextBoxColumn rndDemanda;
        private DataGridViewTextBoxColumn demanda;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn stockAC;
        private DataGridViewTextBoxColumn Perdidas;
        private DataGridViewTextBoxColumn PerdidasAC;
        private DataGridViewTextBoxColumn Optimo;
        private DataGridViewTextBoxColumn OptimoAC;
    }
}