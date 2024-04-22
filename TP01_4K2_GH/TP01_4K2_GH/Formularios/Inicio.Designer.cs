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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.Font = new Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.DarkOrchid;
            btnIniciar.Location = new Point(319, 510);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(256, 49);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Generar números";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Montserrat SemiBold", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(171, 133);
            label1.Name = "label1";
            label1.Size = new Size(570, 81);
            label1.TabIndex = 1;
            label1.Text = "Trabajo práctico 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(291, 282);
            label2.Name = "label2";
            label2.Size = new Size(287, 47);
            label2.TabIndex = 2;
            label2.Text = "Simulación 4K2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Montserrat Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(294, 349);
            label3.Name = "label3";
            label3.Size = new Size(281, 47);
            label3.TabIndex = 3;
            label3.Text = "Grupo H - 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Thistle;
            pictureBox1.Location = new Point(98, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(725, 572);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(915, 676);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIniciar);
            Controls.Add(pictureBox1);
            Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}