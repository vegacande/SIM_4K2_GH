namespace TP3_SIM_G6
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSimular = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSimular
            // 
            btnSimular.BackColor = Color.Plum;
            btnSimular.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimular.ForeColor = Color.White;
            btnSimular.Location = new Point(203, 424);
            btnSimular.Margin = new Padding(5, 4, 5, 4);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(230, 65);
            btnSimular.TabIndex = 0;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = false;
            btnSimular.Click += btnSimular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Violet;
            label3.Location = new Point(74, 218);
            label3.Name = "label3";
            label3.Size = new Size(389, 31);
            label3.TabIndex = 6;
            label3.Text = "Panaderia: venta de facturas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(163, 160);
            label1.Name = "label1";
            label1.Size = new Size(260, 31);
            label1.TabIndex = 7;
            label1.Text = "Modelo Montecarlo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Violet;
            label2.Location = new Point(203, 284);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 8;
            label2.Text = "Grupo H - 4K2";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1224, 621);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnSimular);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimular;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}