namespace TP4_SIM
{
    partial class Simulacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFinPaquete = new System.Windows.Forms.TextBox();
            this.txtLlegadaPaquete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFinReclamo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLlegadaReclamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFinVenta = new System.Windows.Forms.TextBox();
            this.txtLlegadaVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFinAtencion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLlegadaAtencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFinPostales = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLlegadaPostales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvColas = new System.Windows.Forms.DataGridView();
            this.txtCantFilas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIniciarSimulacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrimeraFila = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OFICINA DE CORREOS MOCASA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFinPaquete);
            this.groupBox1.Controls.Add(this.txtLlegadaPaquete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envío de Paquetes";
            // 
            // txtFinPaquete
            // 
            this.txtFinPaquete.Location = new System.Drawing.Point(103, 41);
            this.txtFinPaquete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinPaquete.Name = "txtFinPaquete";
            this.txtFinPaquete.Size = new System.Drawing.Size(85, 19);
            this.txtFinPaquete.TabIndex = 3;
            this.txtFinPaquete.Text = "6";
            // 
            // txtLlegadaPaquete
            // 
            this.txtLlegadaPaquete.Location = new System.Drawing.Point(103, 17);
            this.txtLlegadaPaquete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLlegadaPaquete.Name = "txtLlegadaPaquete";
            this.txtLlegadaPaquete.Size = new System.Drawing.Size(85, 19);
            this.txtLlegadaPaquete.TabIndex = 2;
            this.txtLlegadaPaquete.Text = "2,4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fin atención:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Llegada cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFinReclamo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLlegadaReclamo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reclamaciones y Devoluciones";
            // 
            // txtFinReclamo
            // 
            this.txtFinReclamo.Location = new System.Drawing.Point(103, 44);
            this.txtFinReclamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinReclamo.Name = "txtFinReclamo";
            this.txtFinReclamo.Size = new System.Drawing.Size(85, 19);
            this.txtFinReclamo.TabIndex = 7;
            this.txtFinReclamo.Text = "8,57";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Llegada cliente:";
            // 
            // txtLlegadaReclamo
            // 
            this.txtLlegadaReclamo.Location = new System.Drawing.Point(103, 20);
            this.txtLlegadaReclamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLlegadaReclamo.Name = "txtLlegadaReclamo";
            this.txtLlegadaReclamo.Size = new System.Drawing.Size(85, 19);
            this.txtLlegadaReclamo.TabIndex = 6;
            this.txtLlegadaReclamo.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fin atención:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFinVenta);
            this.groupBox3.Controls.Add(this.txtLlegadaVenta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(42, 216);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(200, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta de Sellos y Sobres";
            // 
            // txtFinVenta
            // 
            this.txtFinVenta.Location = new System.Drawing.Point(103, 45);
            this.txtFinVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinVenta.Name = "txtFinVenta";
            this.txtFinVenta.Size = new System.Drawing.Size(85, 19);
            this.txtFinVenta.TabIndex = 7;
            this.txtFinVenta.Text = "3,33";
            // 
            // txtLlegadaVenta
            // 
            this.txtLlegadaVenta.Location = new System.Drawing.Point(103, 21);
            this.txtLlegadaVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLlegadaVenta.Name = "txtLlegadaVenta";
            this.txtLlegadaVenta.Size = new System.Drawing.Size(85, 19);
            this.txtLlegadaVenta.TabIndex = 6;
            this.txtLlegadaVenta.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fin atención:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Llegada cliente:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFinAtencion);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtLlegadaAtencion);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(42, 303);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(200, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atención Empresarial";
            // 
            // txtFinAtencion
            // 
            this.txtFinAtencion.Location = new System.Drawing.Point(103, 43);
            this.txtFinAtencion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinAtencion.Name = "txtFinAtencion";
            this.txtFinAtencion.Size = new System.Drawing.Size(85, 19);
            this.txtFinAtencion.TabIndex = 11;
            this.txtFinAtencion.Text = "12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Llegada cliente:";
            // 
            // txtLlegadaAtencion
            // 
            this.txtLlegadaAtencion.Location = new System.Drawing.Point(103, 20);
            this.txtLlegadaAtencion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLlegadaAtencion.Name = "txtLlegadaAtencion";
            this.txtLlegadaAtencion.Size = new System.Drawing.Size(85, 19);
            this.txtLlegadaAtencion.TabIndex = 10;
            this.txtLlegadaAtencion.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fin atención:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFinPostales);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtLlegadaPostales);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(42, 387);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(200, 72);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Postales y Envíos Especiales";
            // 
            // txtFinPostales
            // 
            this.txtFinPostales.Location = new System.Drawing.Point(103, 45);
            this.txtFinPostales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinPostales.Name = "txtFinPostales";
            this.txtFinPostales.Size = new System.Drawing.Size(85, 19);
            this.txtFinPostales.TabIndex = 15;
            this.txtFinPostales.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Llegada cliente:";
            // 
            // txtLlegadaPostales
            // 
            this.txtLlegadaPostales.Location = new System.Drawing.Point(103, 21);
            this.txtLlegadaPostales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLlegadaPostales.Name = "txtLlegadaPostales";
            this.txtLlegadaPostales.Size = new System.Drawing.Size(85, 19);
            this.txtLlegadaPostales.TabIndex = 14;
            this.txtLlegadaPostales.Text = "7,5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fin atención:";
            // 
            // dgvColas
            // 
            this.dgvColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColas.Location = new System.Drawing.Point(270, 103);
            this.dgvColas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvColas.Name = "dgvColas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColas.RowHeadersWidth = 51;
            this.dgvColas.RowTemplate.Height = 24;
            this.dgvColas.Size = new System.Drawing.Size(1110, 665);
            this.dgvColas.TabIndex = 3;
            // 
            // txtCantFilas
            // 
            this.txtCantFilas.Location = new System.Drawing.Point(410, 42);
            this.txtCantFilas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantFilas.Name = "txtCantFilas";
            this.txtCantFilas.Size = new System.Drawing.Size(85, 20);
            this.txtCantFilas.TabIndex = 5;
            this.txtCantFilas.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(283, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cant. de líneas a simular:";
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(597, 46);
            this.btnIniciarSimulacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(98, 38);
            this.btnIniciarSimulacion.TabIndex = 6;
            this.btnIniciarSimulacion.Text = "INICIAR SIMULACIÓN";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = true;
            this.btnIniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(301, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mostrar desde la fila:";
            // 
            // txtPrimeraFila
            // 
            this.txtPrimeraFila.Location = new System.Drawing.Point(410, 67);
            this.txtPrimeraFila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimeraFila.Name = "txtPrimeraFila";
            this.txtPrimeraFila.Size = new System.Drawing.Size(85, 20);
            this.txtPrimeraFila.TabIndex = 8;
            this.txtPrimeraFila.Text = "1";
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1391, 800);
            this.Controls.Add(this.txtPrimeraFila);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.txtCantFilas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvColas);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Simulacion";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFinPaquete;
        private System.Windows.Forms.TextBox txtLlegadaPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFinReclamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLlegadaReclamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFinVenta;
        private System.Windows.Forms.TextBox txtLlegadaVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFinAtencion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLlegadaAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFinPostales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLlegadaPostales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvColas;
        private System.Windows.Forms.TextBox txtCantFilas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIniciarSimulacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrimeraFila;
    }
}

