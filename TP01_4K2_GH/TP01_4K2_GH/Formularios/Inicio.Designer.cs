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
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(394, 527);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(213, 49);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar simulación";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 700);
            Controls.Add(btnIniciar);
            Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
    }
}