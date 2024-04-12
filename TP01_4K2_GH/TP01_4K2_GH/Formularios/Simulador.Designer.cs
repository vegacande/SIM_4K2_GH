namespace TP01_4K2_GH.Formularios
{
    partial class Simulador
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
            grillaFrecuencias = new DataGridView();
            intervalo = new DataGridViewTextBoxColumn();
            limInf = new DataGridViewTextBoxColumn();
            limSup = new DataGridViewTextBoxColumn();
            frecObs = new DataGridViewTextBoxColumn();
            frecEsp = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grillaFrecuencias).BeginInit();
            SuspendLayout();
            // 
            // grillaFrecuencias
            // 
            grillaFrecuencias.AllowUserToAddRows = false;
            grillaFrecuencias.AllowUserToDeleteRows = false;
            grillaFrecuencias.BackgroundColor = Color.Lavender;
            grillaFrecuencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFrecuencias.Columns.AddRange(new DataGridViewColumn[] { intervalo, limInf, limSup, frecObs, frecEsp });
            grillaFrecuencias.Location = new Point(641, 92);
            grillaFrecuencias.Name = "grillaFrecuencias";
            grillaFrecuencias.ReadOnly = true;
            grillaFrecuencias.RowHeadersWidth = 51;
            grillaFrecuencias.RowTemplate.Height = 29;
            grillaFrecuencias.Size = new Size(676, 489);
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
            // Simulador
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1458, 693);
            Controls.Add(grillaFrecuencias);
            Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Simulador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)grillaFrecuencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaFrecuencias;
        private DataGridViewTextBoxColumn intervalo;
        private DataGridViewTextBoxColumn limInf;
        private DataGridViewTextBoxColumn limSup;
        private DataGridViewTextBoxColumn frecObs;
        private DataGridViewTextBoxColumn frecEsp;
    }
}