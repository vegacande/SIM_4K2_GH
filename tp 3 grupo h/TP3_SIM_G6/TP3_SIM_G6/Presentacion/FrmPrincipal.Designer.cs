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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnSimular = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSimular
            // 
            btnSimular.BackColor = Color.Plum;
            btnSimular.Font = new Font("Montserrat SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimular.ForeColor = Color.White;
            btnSimular.Location = new Point(372, 392);
            btnSimular.Margin = new Padding(5, 4, 5, 4);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(354, 70);
            btnSimular.TabIndex = 0;
            btnSimular.Text = "Iniciar simulación";
            btnSimular.UseVisualStyleBackColor = false;
            btnSimular.Click += btnSimular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(276, 28);
            label3.Name = "label3";
            label3.Size = new Size(354, 51);
            label3.TabIndex = 6;
            label3.Text = "Venta de facturas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Violet;
            label2.Location = new Point(402, 266);
            label2.Name = "label2";
            label2.Size = new Size(263, 47);
            label2.TabIndex = 8;
            label2.Text = "Grupo H - 4K2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(255, 201);
            label4.Name = "label4";
            label4.Size = new Size(581, 37);
            label4.TabIndex = 9;
            label4.Text = "Trabajo práctico N°4 - Modelo Montecarlo";
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.Thistle;
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(96, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 109);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1113, 528);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnSimular);
            Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panadería";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimular;
        private Label label3;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
    }
}