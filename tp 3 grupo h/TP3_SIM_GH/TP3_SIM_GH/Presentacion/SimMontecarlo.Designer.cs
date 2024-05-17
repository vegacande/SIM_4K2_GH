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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimMontecarlo));
            grdSimulacion = new DataGridView();
            dia = new DataGridViewTextBoxColumn();
            Oferta = new DataGridViewTextBoxColumn();
            rndTipo = new DataGridViewTextBoxColumn();
            TipoDemanda = new DataGridViewTextBoxColumn();
            rndDemanda = new DataGridViewTextBoxColumn();
            demanda = new DataGridViewTextBoxColumn();
            costoProd = new DataGridViewTextBoxColumn();
            ganVenta = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            stockAC = new DataGridViewTextBoxColumn();
            ganSobrante = new DataGridViewTextBoxColumn();
            Perdidas = new DataGridViewTextBoxColumn();
            PerdidasAC = new DataGridViewTextBoxColumn();
            perFaltante = new DataGridViewTextBoxColumn();
            Optimo = new DataGridViewTextBoxColumn();
            OptimoAC = new DataGridViewTextBoxColumn();
            gananDia = new DataGridViewTextBoxColumn();
            ganTotalACu = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtStock = new NumericUpDown();
            lbl = new Label();
            groupBox3 = new GroupBox();
            txtGananciaProm = new TextBox();
            label1 = new Label();
            txtPromOptimo = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btnReiniciar = new Button();
            btnIniciar = new Button();
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
            grdSimulacion.Columns.AddRange(new DataGridViewColumn[] { dia, Oferta, rndTipo, TipoDemanda, rndDemanda, demanda, costoProd, ganVenta, stock, stockAC, ganSobrante, Perdidas, PerdidasAC, perFaltante, Optimo, OptimoAC, gananDia, ganTotalACu });
            grdSimulacion.GridColor = Color.Gray;
            grdSimulacion.Location = new Point(408, 99);
            grdSimulacion.Margin = new Padding(2, 3, 2, 3);
            grdSimulacion.Name = "grdSimulacion";
            grdSimulacion.ReadOnly = true;
            grdSimulacion.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            grdSimulacion.RowsDefaultCellStyle = dataGridViewCellStyle1;
            grdSimulacion.RowTemplate.Height = 29;
            grdSimulacion.Size = new Size(1413, 582);
            grdSimulacion.TabIndex = 4;
            // 
            // dia
            // 
            dia.HeaderText = "Día";
            dia.MinimumWidth = 6;
            dia.Name = "dia";
            dia.ReadOnly = true;
            dia.Width = 72;
            // 
            // Oferta
            // 
            Oferta.HeaderText = "Oferta";
            Oferta.MinimumWidth = 6;
            Oferta.Name = "Oferta";
            Oferta.ReadOnly = true;
            Oferta.Width = 98;
            // 
            // rndTipo
            // 
            rndTipo.HeaderText = "Rnd Tipo";
            rndTipo.MinimumWidth = 6;
            rndTipo.Name = "rndTipo";
            rndTipo.ReadOnly = true;
            rndTipo.Width = 112;
            // 
            // TipoDemanda
            // 
            TipoDemanda.HeaderText = "Tipo Demanda";
            TipoDemanda.MinimumWidth = 6;
            TipoDemanda.Name = "TipoDemanda";
            TipoDemanda.ReadOnly = true;
            TipoDemanda.Width = 161;
            // 
            // rndDemanda
            // 
            rndDemanda.HeaderText = "Rnd Demanda";
            rndDemanda.MinimumWidth = 6;
            rndDemanda.Name = "rndDemanda";
            rndDemanda.ReadOnly = true;
            rndDemanda.Width = 159;
            // 
            // demanda
            // 
            demanda.HeaderText = "Demanda";
            demanda.MinimumWidth = 6;
            demanda.Name = "demanda";
            demanda.ReadOnly = true;
            demanda.Width = 132;
            // 
            // costoProd
            // 
            costoProd.HeaderText = "Costo producción";
            costoProd.MinimumWidth = 6;
            costoProd.Name = "costoProd";
            costoProd.ReadOnly = true;
            costoProd.Width = 182;
            // 
            // ganVenta
            // 
            ganVenta.HeaderText = "Ganancia de venta";
            ganVenta.MinimumWidth = 6;
            ganVenta.Name = "ganVenta";
            ganVenta.ReadOnly = true;
            ganVenta.Width = 146;
            // 
            // stock
            // 
            stock.HeaderText = "Sobrante";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 122;
            // 
            // stockAC
            // 
            stockAC.HeaderText = "Sobrante AC";
            stockAC.MinimumWidth = 6;
            stockAC.Name = "stockAC";
            stockAC.ReadOnly = true;
            stockAC.Width = 140;
            // 
            // ganSobrante
            // 
            ganSobrante.HeaderText = "Ganancia sobrante";
            ganSobrante.MinimumWidth = 6;
            ganSobrante.Name = "ganSobrante";
            ganSobrante.ReadOnly = true;
            ganSobrante.Width = 192;
            // 
            // Perdidas
            // 
            Perdidas.HeaderText = "Pérdidas";
            Perdidas.MinimumWidth = 6;
            Perdidas.Name = "Perdidas";
            Perdidas.ReadOnly = true;
            Perdidas.Width = 121;
            // 
            // PerdidasAC
            // 
            PerdidasAC.HeaderText = "Pérdidas AC";
            PerdidasAC.MinimumWidth = 6;
            PerdidasAC.Name = "PerdidasAC";
            PerdidasAC.ReadOnly = true;
            PerdidasAC.Width = 139;
            // 
            // perFaltante
            // 
            perFaltante.HeaderText = "Pérdida faltante";
            perFaltante.MinimumWidth = 6;
            perFaltante.Name = "perFaltante";
            perFaltante.ReadOnly = true;
            perFaltante.Width = 172;
            // 
            // Optimo
            // 
            Optimo.HeaderText = "Cantidad óptima";
            Optimo.MinimumWidth = 6;
            Optimo.Name = "Optimo";
            Optimo.ReadOnly = true;
            Optimo.Width = 177;
            // 
            // OptimoAC
            // 
            OptimoAC.HeaderText = "Cant óptima AC";
            OptimoAC.MinimumWidth = 6;
            OptimoAC.Name = "OptimoAC";
            OptimoAC.ReadOnly = true;
            OptimoAC.Width = 146;
            // 
            // gananDia
            // 
            gananDia.HeaderText = "Ganancia total";
            gananDia.MinimumWidth = 6;
            gananDia.Name = "gananDia";
            gananDia.ReadOnly = true;
            gananDia.Width = 158;
            // 
            // ganTotalACu
            // 
            ganTotalACu.HeaderText = "Ganancia total AC";
            ganTotalACu.MinimumWidth = 6;
            ganTotalACu.Name = "ganTotalACu";
            ganTotalACu.ReadOnly = true;
            ganTotalACu.Width = 163;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Plum;
            label3.Location = new Point(28, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(326, 47);
            label3.TabIndex = 5;
            label3.Text = "Venta de facturas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(lbl);
            groupBox1.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 99);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(368, 154);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parámetros";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtStock.Increment = new decimal(new int[] { 12, 0, 0, 0 });
            txtStock.Location = new Point(224, 63);
            txtStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(90, 28);
            txtStock.TabIndex = 22;
            txtStock.Value = new decimal(new int[] { 96, 0, 0, 0 });
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(28, 65);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(187, 24);
            lbl.TabIndex = 23;
            lbl.Text = "Stock inicial (Oferta)";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGananciaProm);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtPromOptimo);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(20, 298);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(369, 190);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // txtGananciaProm
            // 
            txtGananciaProm.Enabled = false;
            txtGananciaProm.Location = new Point(65, 156);
            txtGananciaProm.Margin = new Padding(2, 3, 2, 3);
            txtGananciaProm.Name = "txtGananciaProm";
            txtGananciaProm.Size = new Size(138, 28);
            txtGananciaProm.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 24;
            label1.Text = "Ganancia promedio";
            // 
            // txtPromOptimo
            // 
            txtPromOptimo.Enabled = false;
            txtPromOptimo.Location = new Point(65, 78);
            txtPromOptimo.Margin = new Padding(2, 3, 2, 3);
            txtPromOptimo.Name = "txtPromOptimo";
            txtPromOptimo.Size = new Size(138, 28);
            txtPromOptimo.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 78);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 24);
            label12.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 45);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(360, 21);
            label11.TabIndex = 20;
            label11.Text = "Número optimo de facturas a producir por día";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Plum;
            btnReiniciar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(20, 521);
            btnReiniciar.Margin = new Padding(2, 3, 2, 3);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(134, 47);
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
            btnIniciar.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(177, 521);
            btnIniciar.Margin = new Padding(2, 3, 2, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(211, 47);
            btnIniciar.TabIndex = 10;
            btnIniciar.Text = "Iniciar simulación";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // SimMontecarlo
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1844, 693);
            Controls.Add(btnIniciar);
            Controls.Add(btnReiniciar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(grdSimulacion);
            Font = new Font("Montserrat Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
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
        private NumericUpDown txtStock;
        private Label lbl;
        private DataGridViewTextBoxColumn dia;
        private DataGridViewTextBoxColumn Oferta;
        private DataGridViewTextBoxColumn rndTipo;
        private DataGridViewTextBoxColumn TipoDemanda;
        private DataGridViewTextBoxColumn rndDemanda;
        private DataGridViewTextBoxColumn demanda;
        private DataGridViewTextBoxColumn costoProd;
        private DataGridViewTextBoxColumn ganVenta;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn stockAC;
        private DataGridViewTextBoxColumn ganSobrante;
        private DataGridViewTextBoxColumn Perdidas;
        private DataGridViewTextBoxColumn PerdidasAC;
        private DataGridViewTextBoxColumn perFaltante;
        private DataGridViewTextBoxColumn Optimo;
        private DataGridViewTextBoxColumn OptimoAC;
        private DataGridViewTextBoxColumn gananDia;
        private DataGridViewTextBoxColumn ganTotalACu;
        private TextBox txtGananciaProm;
        private Label label1;
    }
}