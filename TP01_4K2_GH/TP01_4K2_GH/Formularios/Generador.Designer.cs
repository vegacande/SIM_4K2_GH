namespace TP01_4K2_GH.Formularios
{
    partial class Generador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grillaFrecuencias = new DataGridView();
            intervalo = new DataGridViewTextBoxColumn();
            limInf = new DataGridViewTextBoxColumn();
            limSup = new DataGridViewTextBoxColumn();
            frecObs = new DataGridViewTextBoxColumn();
            frecEsp = new DataGridViewTextBoxColumn();
            grillaAleatorios = new DataGridView();
            idNum = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            rbExponencial = new RadioButton();
            rbUniforme = new RadioButton();
            rbNormal = new RadioButton();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            rb23 = new RadioButton();
            rb12 = new RadioButton();
            rb16 = new RadioButton();
            rb10 = new RadioButton();
            txtTamañoMuestra = new MaskedTextBox();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            chartFrecuencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grillaConFEAgrupada = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            txtA = new TextBox();
            txtB = new TextBox();
            txtLambda = new TextBox();
            txtMedia = new TextBox();
            txtDesv = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grillaFrecuencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAleatorios).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFrecuencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaConFEAgrupada).BeginInit();
            SuspendLayout();
            // 
            // grillaFrecuencias
            // 
            grillaFrecuencias.AllowUserToAddRows = false;
            grillaFrecuencias.AllowUserToDeleteRows = false;
            grillaFrecuencias.BackgroundColor = Color.Lavender;
            grillaFrecuencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFrecuencias.Columns.AddRange(new DataGridViewColumn[] { intervalo, limInf, limSup, frecObs, frecEsp });
            grillaFrecuencias.Location = new Point(1027, 28);
            grillaFrecuencias.Name = "grillaFrecuencias";
            grillaFrecuencias.ReadOnly = true;
            grillaFrecuencias.RowHeadersWidth = 51;
            grillaFrecuencias.RowTemplate.Height = 29;
            grillaFrecuencias.Size = new Size(676, 335);
            grillaFrecuencias.TabIndex = 0;
            // 
            // intervalo
            // 
            intervalo.HeaderText = "Intervalo";
            intervalo.MinimumWidth = 6;
            intervalo.Name = "intervalo";
            intervalo.ReadOnly = true;
            intervalo.Width = 125;
            // 
            // limInf
            // 
            limInf.HeaderText = "LI";
            limInf.MinimumWidth = 6;
            limInf.Name = "limInf";
            limInf.ReadOnly = true;
            limInf.Width = 125;
            // 
            // limSup
            // 
            limSup.HeaderText = "LS";
            limSup.MinimumWidth = 6;
            limSup.Name = "limSup";
            limSup.ReadOnly = true;
            limSup.Width = 125;
            // 
            // frecObs
            // 
            frecObs.HeaderText = "FO";
            frecObs.MinimumWidth = 6;
            frecObs.Name = "frecObs";
            frecObs.ReadOnly = true;
            frecObs.Width = 125;
            // 
            // frecEsp
            // 
            frecEsp.HeaderText = "FE";
            frecEsp.MinimumWidth = 6;
            frecEsp.Name = "frecEsp";
            frecEsp.ReadOnly = true;
            frecEsp.Width = 125;
            // 
            // grillaAleatorios
            // 
            grillaAleatorios.AllowUserToAddRows = false;
            grillaAleatorios.AllowUserToDeleteRows = false;
            grillaAleatorios.BackgroundColor = Color.Lavender;
            grillaAleatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAleatorios.Columns.AddRange(new DataGridViewColumn[] { idNum, numero });
            grillaAleatorios.Location = new Point(497, 28);
            grillaAleatorios.Name = "grillaAleatorios";
            grillaAleatorios.ReadOnly = true;
            grillaAleatorios.RowHeadersWidth = 51;
            grillaAleatorios.RowTemplate.Height = 29;
            grillaAleatorios.Size = new Size(288, 448);
            grillaAleatorios.TabIndex = 1;
            // 
            // idNum
            // 
            idNum.HeaderText = "Id";
            idNum.MinimumWidth = 6;
            idNum.Name = "idNum";
            idNum.ReadOnly = true;
            idNum.Width = 80;
            // 
            // numero
            // 
            numero.HeaderText = "Número";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbExponencial);
            groupBox1.Controls.Add(rbUniforme);
            groupBox1.Controls.Add(rbNormal);
            groupBox1.Location = new Point(42, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 108);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Distribución";
            // 
            // rbExponencial
            // 
            rbExponencial.AutoSize = true;
            rbExponencial.Location = new Point(115, 58);
            rbExponencial.Name = "rbExponencial";
            rbExponencial.Size = new Size(102, 21);
            rbExponencial.TabIndex = 2;
            rbExponencial.TabStop = true;
            rbExponencial.Text = "Exponencial";
            rbExponencial.UseVisualStyleBackColor = true;
            rbExponencial.CheckedChanged += btnExponencial_CheckedChanged;
            // 
            // rbUniforme
            // 
            rbUniforme.AutoSize = true;
            rbUniforme.Location = new Point(257, 58);
            rbUniforme.Name = "rbUniforme";
            rbUniforme.Size = new Size(83, 21);
            rbUniforme.TabIndex = 1;
            rbUniforme.TabStop = true;
            rbUniforme.Text = "Uniforme";
            rbUniforme.UseVisualStyleBackColor = true;
            rbUniforme.CheckedChanged += btnUniforme_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(13, 58);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(71, 21);
            rbNormal.TabIndex = 0;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += btnNormal_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 191);
            label1.Name = "label1";
            label1.Size = new Size(159, 17);
            label1.TabIndex = 3;
            label1.Text = "Tamaño de muestra (N)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDesv);
            groupBox2.Controls.Add(txtMedia);
            groupBox2.Controls.Add(txtLambda);
            groupBox2.Controls.Add(txtB);
            groupBox2.Controls.Add(txtA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(42, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 175);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 86);
            label6.Name = "label6";
            label6.Size = new Size(16, 18);
            label6.TabIndex = 15;
            label6.Text = "λ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 44);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(191, 126);
            label5.Name = "label5";
            label5.Size = new Size(17, 18);
            label5.TabIndex = 14;
            label5.Text = "σ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 44);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 7;
            label2.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 126);
            label4.Name = "label4";
            label4.Size = new Size(16, 18);
            label4.TabIndex = 13;
            label4.Text = "μ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rb23);
            groupBox3.Controls.Add(rb12);
            groupBox3.Controls.Add(rb16);
            groupBox3.Controls.Add(rb10);
            groupBox3.Location = new Point(42, 255);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 108);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intervalos";
            // 
            // rb23
            // 
            rb23.AutoSize = true;
            rb23.Location = new Point(257, 58);
            rb23.Name = "rb23";
            rb23.Size = new Size(42, 21);
            rb23.TabIndex = 3;
            rb23.TabStop = true;
            rb23.Text = "23";
            rb23.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            rb12.AutoSize = true;
            rb12.Location = new Point(98, 58);
            rb12.Name = "rb12";
            rb12.Size = new Size(42, 21);
            rb12.TabIndex = 2;
            rb12.TabStop = true;
            rb12.Text = "12";
            rb12.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            rb16.AutoSize = true;
            rb16.Location = new Point(182, 58);
            rb16.Name = "rb16";
            rb16.Size = new Size(42, 21);
            rb16.TabIndex = 1;
            rb16.TabStop = true;
            rb16.Text = "16";
            rb16.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            rb10.AutoSize = true;
            rb10.Location = new Point(28, 58);
            rb10.Name = "rb10";
            rb10.Size = new Size(42, 21);
            rb10.TabIndex = 0;
            rb10.TabStop = true;
            rb10.Text = "10";
            rb10.UseVisualStyleBackColor = true;
            // 
            // txtTamañoMuestra
            // 
            txtTamañoMuestra.Location = new Point(261, 191);
            txtTamañoMuestra.Mask = "9999999";
            txtTamañoMuestra.Name = "txtTamañoMuestra";
            txtTamañoMuestra.Size = new Size(125, 23);
            txtTamañoMuestra.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(55, 597);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 60);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(224, 597);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(136, 60);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar números";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // chartFrecuencia
            // 
            chartArea3.Name = "ChartArea1";
            chartFrecuencia.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartFrecuencia.Legends.Add(legend3);
            chartFrecuencia.Location = new Point(458, 518);
            chartFrecuencia.Name = "chartFrecuencia";
            chartFrecuencia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFrecuencia.Series.Add(series3);
            chartFrecuencia.Size = new Size(546, 258);
            chartFrecuencia.TabIndex = 12;
            chartFrecuencia.Text = "Tabla de frecuencias";
            // 
            // grillaConFEAgrupada
            // 
            grillaConFEAgrupada.AllowUserToAddRows = false;
            grillaConFEAgrupada.AllowUserToDeleteRows = false;
            grillaConFEAgrupada.BackgroundColor = Color.Lavender;
            grillaConFEAgrupada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaConFEAgrupada.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            grillaConFEAgrupada.Location = new Point(1027, 385);
            grillaConFEAgrupada.Name = "grillaConFEAgrupada";
            grillaConFEAgrupada.ReadOnly = true;
            grillaConFEAgrupada.RowHeadersWidth = 51;
            grillaConFEAgrupada.RowTemplate.Height = 29;
            grillaConFEAgrupada.Size = new Size(676, 335);
            grillaConFEAgrupada.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Intervalo";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "LI";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "LS";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "FO";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "FE";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // txtA
            // 
            txtA.Location = new Point(61, 41);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 14;
            // 
            // txtB
            // 
            txtB.Location = new Point(219, 38);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 15;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(63, 83);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(100, 23);
            txtLambda.TabIndex = 20;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(61, 126);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 21;
            // 
            // txtDesv
            // 
            txtDesv.Location = new Point(218, 126);
            txtDesv.Name = "txtDesv";
            txtDesv.Size = new Size(100, 23);
            txtDesv.TabIndex = 22;
            // 
            // Generador
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1736, 807);
            Controls.Add(grillaConFEAgrupada);
            Controls.Add(chartFrecuencia);
            Controls.Add(btnGenerar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtTamañoMuestra);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(grillaAleatorios);
            Controls.Add(grillaFrecuencias);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Generador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)grillaFrecuencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAleatorios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFrecuencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaConFEAgrupada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaFrecuencias;
        private DataGridViewTextBoxColumn intervalo;
        private DataGridViewTextBoxColumn limInf;
        private DataGridViewTextBoxColumn limSup;
        private DataGridViewTextBoxColumn frecObs;
        private DataGridViewTextBoxColumn frecEsp;
        private DataGridView grillaAleatorios;
        private DataGridViewTextBoxColumn idNum;
        private DataGridViewTextBoxColumn numero;
        private GroupBox groupBox1;
        private RadioButton rbExponencial;
        private RadioButton rbUniforme;
        private RadioButton rbNormal;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rb12;
        private RadioButton rb16;
        private RadioButton rb10;
        private MaskedTextBox txtTamañoMuestra;
        private Label label3;
        private Label label2;
        private RadioButton rb23;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnLimpiar;
        private Button btnGenerar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrecuencia;
        private DataGridView grillaConFEAgrupada;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TextBox txtMedia;
        private TextBox txtLambda;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtDesv;
    }
}