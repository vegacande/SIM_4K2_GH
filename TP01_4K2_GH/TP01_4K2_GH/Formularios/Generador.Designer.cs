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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grillaFrecuencias = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaAleatorios = new System.Windows.Forms.DataGridView();
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExponencial = new System.Windows.Forms.RadioButton();
            this.rbUniforme = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesv = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb23 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.txtTamañoMuestra = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chartFrecuencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtValorTabulado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_resHipotesis = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaKS = new System.Windows.Forms.DataGridView();
            this.intervaloKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limInfKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limSupKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProbObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProbEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difProbabilidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_resHipotesisKS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKSTabulado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAleatorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrecuencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaKS)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaFrecuencias
            // 
            this.grillaFrecuencias.AllowUserToAddRows = false;
            this.grillaFrecuencias.AllowUserToDeleteRows = false;
            this.grillaFrecuencias.BackgroundColor = System.Drawing.Color.Lavender;
            this.grillaFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.limInf,
            this.limSup,
            this.frecObs,
            this.frecEsp,
            this.CHI});
            this.grillaFrecuencias.Location = new System.Drawing.Point(1027, 28);
            this.grillaFrecuencias.Name = "grillaFrecuencias";
            this.grillaFrecuencias.ReadOnly = true;
            this.grillaFrecuencias.RowHeadersWidth = 51;
            this.grillaFrecuencias.RowTemplate.Height = 29;
            this.grillaFrecuencias.Size = new System.Drawing.Size(676, 335);
            this.grillaFrecuencias.TabIndex = 0;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.MinimumWidth = 6;
            this.intervalo.Name = "intervalo";
            this.intervalo.ReadOnly = true;
            this.intervalo.Width = 125;
            // 
            // limInf
            // 
            this.limInf.HeaderText = "LI";
            this.limInf.MinimumWidth = 6;
            this.limInf.Name = "limInf";
            this.limInf.ReadOnly = true;
            this.limInf.Width = 125;
            // 
            // limSup
            // 
            this.limSup.HeaderText = "LS";
            this.limSup.MinimumWidth = 6;
            this.limSup.Name = "limSup";
            this.limSup.ReadOnly = true;
            this.limSup.Width = 125;
            // 
            // frecObs
            // 
            this.frecObs.HeaderText = "FO";
            this.frecObs.MinimumWidth = 6;
            this.frecObs.Name = "frecObs";
            this.frecObs.ReadOnly = true;
            this.frecObs.Width = 125;
            // 
            // frecEsp
            // 
            this.frecEsp.HeaderText = "FE";
            this.frecEsp.MinimumWidth = 6;
            this.frecEsp.Name = "frecEsp";
            this.frecEsp.ReadOnly = true;
            this.frecEsp.Width = 125;
            // 
            // CHI
            // 
            this.CHI.HeaderText = "CHI";
            this.CHI.MinimumWidth = 6;
            this.CHI.Name = "CHI";
            this.CHI.ReadOnly = true;
            this.CHI.Width = 125;
            // 
            // grillaAleatorios
            // 
            this.grillaAleatorios.AllowUserToAddRows = false;
            this.grillaAleatorios.AllowUserToDeleteRows = false;
            this.grillaAleatorios.BackgroundColor = System.Drawing.Color.Lavender;
            this.grillaAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAleatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNum,
            this.numero});
            this.grillaAleatorios.Location = new System.Drawing.Point(497, 28);
            this.grillaAleatorios.Name = "grillaAleatorios";
            this.grillaAleatorios.ReadOnly = true;
            this.grillaAleatorios.RowHeadersWidth = 51;
            this.grillaAleatorios.RowTemplate.Height = 29;
            this.grillaAleatorios.Size = new System.Drawing.Size(288, 448);
            this.grillaAleatorios.TabIndex = 1;
            // 
            // idNum
            // 
            this.idNum.HeaderText = "Id";
            this.idNum.MinimumWidth = 6;
            this.idNum.Name = "idNum";
            this.idNum.ReadOnly = true;
            this.idNum.Width = 80;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExponencial);
            this.groupBox1.Controls.Add(this.rbUniforme);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(42, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribución";
            // 
            // rbExponencial
            // 
            this.rbExponencial.AutoSize = true;
            this.rbExponencial.Location = new System.Drawing.Point(115, 58);
            this.rbExponencial.Name = "rbExponencial";
            this.rbExponencial.Size = new System.Drawing.Size(120, 24);
            this.rbExponencial.TabIndex = 2;
            this.rbExponencial.TabStop = true;
            this.rbExponencial.Text = "Exponencial";
            this.rbExponencial.UseVisualStyleBackColor = true;
            this.rbExponencial.CheckedChanged += new System.EventHandler(this.btnExponencial_CheckedChanged);
            // 
            // rbUniforme
            // 
            this.rbUniforme.AutoSize = true;
            this.rbUniforme.Location = new System.Drawing.Point(257, 58);
            this.rbUniforme.Name = "rbUniforme";
            this.rbUniforme.Size = new System.Drawing.Size(98, 24);
            this.rbUniforme.TabIndex = 1;
            this.rbUniforme.TabStop = true;
            this.rbUniforme.Text = "Uniforme";
            this.rbUniforme.UseVisualStyleBackColor = true;
            this.rbUniforme.CheckedChanged += new System.EventHandler(this.btnUniforme_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(13, 58);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(84, 24);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.btnNormal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamaño de muestra (N)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesv);
            this.groupBox2.Controls.Add(this.txtMedia);
            this.groupBox2.Controls.Add(this.txtLambda);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(42, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtDesv
            // 
            this.txtDesv.Location = new System.Drawing.Point(218, 126);
            this.txtDesv.Name = "txtDesv";
            this.txtDesv.Size = new System.Drawing.Size(100, 27);
            this.txtDesv.TabIndex = 22;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(61, 126);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 27);
            this.txtMedia.TabIndex = 21;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(63, 83);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 27);
            this.txtLambda.TabIndex = 20;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(219, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 27);
            this.txtB.TabIndex = 15;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(61, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 27);
            this.txtA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "λ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(191, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "σ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "μ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb23);
            this.groupBox3.Controls.Add(this.rb12);
            this.groupBox3.Controls.Add(this.rb16);
            this.groupBox3.Controls.Add(this.rb10);
            this.groupBox3.Location = new System.Drawing.Point(42, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 108);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intervalos";
            // 
            // rb23
            // 
            this.rb23.AutoSize = true;
            this.rb23.Location = new System.Drawing.Point(257, 58);
            this.rb23.Name = "rb23";
            this.rb23.Size = new System.Drawing.Size(48, 24);
            this.rb23.TabIndex = 3;
            this.rb23.TabStop = true;
            this.rb23.Text = "23";
            this.rb23.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(98, 58);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(48, 24);
            this.rb12.TabIndex = 2;
            this.rb12.TabStop = true;
            this.rb12.Text = "12";
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(182, 58);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(48, 24);
            this.rb16.TabIndex = 1;
            this.rb16.TabStop = true;
            this.rb16.Text = "16";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(28, 58);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(48, 24);
            this.rb10.TabIndex = 0;
            this.rb10.TabStop = true;
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // txtTamañoMuestra
            // 
            this.txtTamañoMuestra.Location = new System.Drawing.Point(261, 191);
            this.txtTamañoMuestra.Mask = "9999999";
            this.txtTamañoMuestra.Name = "txtTamañoMuestra";
            this.txtTamañoMuestra.Size = new System.Drawing.Size(125, 27);
            this.txtTamañoMuestra.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(55, 597);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 60);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(224, 597);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 60);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // chartFrecuencia
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFrecuencia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFrecuencia.Legends.Add(legend1);
            this.chartFrecuencia.Location = new System.Drawing.Point(460, 537);
            this.chartFrecuencia.Name = "chartFrecuencia";
            this.chartFrecuencia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFrecuencia.Series.Add(series1);
            this.chartFrecuencia.Size = new System.Drawing.Size(546, 258);
            this.chartFrecuencia.TabIndex = 12;
            this.chartFrecuencia.Text = "Tabla de frecuencias";
            // 
            // txtValorTabulado
            // 
            this.txtValorTabulado.Location = new System.Drawing.Point(814, 89);
            this.txtValorTabulado.Name = "txtValorTabulado";
            this.txtValorTabulado.ReadOnly = true;
            this.txtValorTabulado.Size = new System.Drawing.Size(100, 27);
            this.txtValorTabulado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(811, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CHI tabulado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(814, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Resultado";
            // 
            // lbl_resHipotesis
            // 
            this.lbl_resHipotesis.AutoSize = true;
            this.lbl_resHipotesis.Location = new System.Drawing.Point(814, 160);
            this.lbl_resHipotesis.Name = "lbl_resHipotesis";
            this.lbl_resHipotesis.Size = new System.Drawing.Size(17, 20);
            this.lbl_resHipotesis.TabIndex = 17;
            this.lbl_resHipotesis.Text = "..";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Intervalo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "LI";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "LS";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "FO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // po
            // 
            this.po.HeaderText = "PO";
            this.po.MinimumWidth = 6;
            this.po.Name = "po";
            this.po.Width = 125;
            // 
            // pe
            // 
            this.pe.HeaderText = "PE";
            this.pe.MinimumWidth = 6;
            this.pe.Name = "pe";
            this.pe.Width = 125;
            // 
            // po_ac
            // 
            this.po_ac.HeaderText = "PO AC";
            this.po_ac.MinimumWidth = 6;
            this.po_ac.Name = "po_ac";
            this.po_ac.Width = 125;
            // 
            // pe_ac
            // 
            this.pe_ac.HeaderText = "PE AC";
            this.pe_ac.MinimumWidth = 6;
            this.pe_ac.Name = "pe_ac";
            this.pe_ac.Width = 125;
            // 
            // grillaKS
            // 
            this.grillaKS.AllowUserToAddRows = false;
            this.grillaKS.AllowUserToDeleteRows = false;
            this.grillaKS.BackgroundColor = System.Drawing.Color.Lavender;
            this.grillaKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervaloKS,
            this.limInfKS,
            this.limSupKS,
            this.foKS,
            this.feKS,
            this.probObs,
            this.probEsp,
            this.totalProbObs,
            this.totalProbEsp,
            this.difProbabilidades,
            this.maxKS});
            this.grillaKS.Location = new System.Drawing.Point(1027, 393);
            this.grillaKS.Name = "grillaKS";
            this.grillaKS.ReadOnly = true;
            this.grillaKS.RowHeadersWidth = 51;
            this.grillaKS.RowTemplate.Height = 29;
            this.grillaKS.Size = new System.Drawing.Size(676, 360);
            this.grillaKS.TabIndex = 18;
            // 
            // intervaloKS
            // 
            this.intervaloKS.HeaderText = "Intervalo";
            this.intervaloKS.MinimumWidth = 6;
            this.intervaloKS.Name = "intervaloKS";
            this.intervaloKS.ReadOnly = true;
            this.intervaloKS.Width = 125;
            // 
            // limInfKS
            // 
            this.limInfKS.HeaderText = "LI";
            this.limInfKS.MinimumWidth = 6;
            this.limInfKS.Name = "limInfKS";
            this.limInfKS.ReadOnly = true;
            this.limInfKS.Width = 125;
            // 
            // limSupKS
            // 
            this.limSupKS.HeaderText = "LS";
            this.limSupKS.MinimumWidth = 6;
            this.limSupKS.Name = "limSupKS";
            this.limSupKS.ReadOnly = true;
            this.limSupKS.Width = 125;
            // 
            // foKS
            // 
            this.foKS.HeaderText = "FO";
            this.foKS.MinimumWidth = 6;
            this.foKS.Name = "foKS";
            this.foKS.ReadOnly = true;
            this.foKS.Width = 125;
            // 
            // feKS
            // 
            this.feKS.HeaderText = "FE";
            this.feKS.MinimumWidth = 6;
            this.feKS.Name = "feKS";
            this.feKS.ReadOnly = true;
            this.feKS.Width = 125;
            // 
            // probObs
            // 
            this.probObs.HeaderText = "PO";
            this.probObs.MinimumWidth = 6;
            this.probObs.Name = "probObs";
            this.probObs.ReadOnly = true;
            this.probObs.Width = 125;
            // 
            // probEsp
            // 
            this.probEsp.HeaderText = "PE";
            this.probEsp.MinimumWidth = 6;
            this.probEsp.Name = "probEsp";
            this.probEsp.ReadOnly = true;
            this.probEsp.Width = 125;
            // 
            // totalProbObs
            // 
            this.totalProbObs.HeaderText = "PO AC";
            this.totalProbObs.MinimumWidth = 6;
            this.totalProbObs.Name = "totalProbObs";
            this.totalProbObs.ReadOnly = true;
            this.totalProbObs.Width = 125;
            // 
            // totalProbEsp
            // 
            this.totalProbEsp.HeaderText = "PE AC";
            this.totalProbEsp.MinimumWidth = 6;
            this.totalProbEsp.Name = "totalProbEsp";
            this.totalProbEsp.ReadOnly = true;
            this.totalProbEsp.Width = 125;
            // 
            // difProbabilidades
            // 
            this.difProbabilidades.HeaderText = "PO AC - PE AC";
            this.difProbabilidades.MinimumWidth = 6;
            this.difProbabilidades.Name = "difProbabilidades";
            this.difProbabilidades.ReadOnly = true;
            this.difProbabilidades.Width = 125;
            // 
            // maxKS
            // 
            this.maxKS.HeaderText = "MAX KS";
            this.maxKS.MinimumWidth = 6;
            this.maxKS.Name = "maxKS";
            this.maxKS.ReadOnly = true;
            this.maxKS.Width = 125;
            // 
            // lbl_resHipotesisKS
            // 
            this.lbl_resHipotesisKS.AutoSize = true;
            this.lbl_resHipotesisKS.Location = new System.Drawing.Point(811, 487);
            this.lbl_resHipotesisKS.Name = "lbl_resHipotesisKS";
            this.lbl_resHipotesisKS.Size = new System.Drawing.Size(17, 20);
            this.lbl_resHipotesisKS.TabIndex = 22;
            this.lbl_resHipotesisKS.Text = "..";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(808, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Resultado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(808, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "KS tabulado";
            // 
            // txtKSTabulado
            // 
            this.txtKSTabulado.Location = new System.Drawing.Point(811, 418);
            this.txtKSTabulado.Name = "txtKSTabulado";
            this.txtKSTabulado.ReadOnly = true;
            this.txtKSTabulado.Size = new System.Drawing.Size(100, 27);
            this.txtKSTabulado.TabIndex = 19;
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1736, 807);
            this.Controls.Add(this.lbl_resHipotesisKS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKSTabulado);
            this.Controls.Add(this.grillaKS);
            this.Controls.Add(this.lbl_resHipotesis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorTabulado);
            this.Controls.Add(this.chartFrecuencia);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTamañoMuestra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grillaAleatorios);
            this.Controls.Add(this.grillaFrecuencias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)(this.grillaFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAleatorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrecuencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtMedia;
        private TextBox txtLambda;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtDesv;
        private DataGridViewTextBoxColumn CHI;
        private TextBox txtValorTabulado;
        private Label label7;
        private Label label8;
        private Label lbl_resHipotesis;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn po;
        private DataGridViewTextBoxColumn pe;
        private DataGridViewTextBoxColumn po_ac;
        private DataGridViewTextBoxColumn pe_ac;
        private DataGridView grillaKS;
        private DataGridViewTextBoxColumn intervaloKS;
        private DataGridViewTextBoxColumn limInfKS;
        private DataGridViewTextBoxColumn limSupKS;
        private DataGridViewTextBoxColumn foKS;
        private DataGridViewTextBoxColumn feKS;
        private DataGridViewTextBoxColumn probObs;
        private DataGridViewTextBoxColumn probEsp;
        private DataGridViewTextBoxColumn totalProbObs;
        private DataGridViewTextBoxColumn totalProbEsp;
        private DataGridViewTextBoxColumn difProbabilidades;
        private DataGridViewTextBoxColumn maxKS;
        private Label lbl_resHipotesisKS;
        private Label label10;
        private Label label11;
        private TextBox txtKSTabulado;
    }
}