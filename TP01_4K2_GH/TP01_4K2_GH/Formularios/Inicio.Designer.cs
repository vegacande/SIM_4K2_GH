namespace TP01_4K2_GH
{
    partial class Form1
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
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(149, 523);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(256, 49);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Generar números";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 121);
            label1.Name = "label1";
            label1.Size = new Size(465, 65);
            label1.TabIndex = 1;
            label1.Text = "Trabajo práctico 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 232);
            label2.Name = "label2";
            label2.Size = new Size(287, 47);
            label2.TabIndex = 2;
            label2.Text = "Simulación 4K2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 306);
            label3.Name = "label3";
            label3.Size = new Size(281, 47);
            label3.TabIndex = 3;
            label3.Text = "Grupo H - 2024";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 700);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}