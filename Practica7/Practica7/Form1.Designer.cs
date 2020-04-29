namespace Practica7
{
    partial class Form1
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
            this.btnMultihilos = new System.Windows.Forms.Button();
            this.progress1 = new System.Windows.Forms.ProgressBar();
            this.progress2 = new System.Windows.Forms.ProgressBar();
            this.progress3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultihilos
            // 
            this.btnMultihilos.Location = new System.Drawing.Point(49, 41);
            this.btnMultihilos.Name = "btnMultihilos";
            this.btnMultihilos.Size = new System.Drawing.Size(75, 23);
            this.btnMultihilos.TabIndex = 0;
            this.btnMultihilos.Text = "Ejecutar";
            this.btnMultihilos.UseVisualStyleBackColor = true;
            this.btnMultihilos.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // progress1
            // 
            this.progress1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progress1.Location = new System.Drawing.Point(179, 10);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(175, 23);
            this.progress1.TabIndex = 1;
            // 
            // progress2
            // 
            this.progress2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progress2.Location = new System.Drawing.Point(371, 11);
            this.progress2.Name = "progress2";
            this.progress2.Size = new System.Drawing.Size(175, 22);
            this.progress2.TabIndex = 2;
            // 
            // progress3
            // 
            this.progress3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progress3.Location = new System.Drawing.Point(581, 10);
            this.progress3.Name = "progress3";
            this.progress3.Size = new System.Drawing.Size(175, 21);
            this.progress3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Multihilos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secuencial";
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(49, 277);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(75, 23);
            this.btnSecuencial.TabIndex = 6;
            this.btnSecuencial.Text = "Ejecutar";
            this.btnSecuencial.UseVisualStyleBackColor = true;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 162);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(175, 162);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 43);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(175, 162);
            this.textBox3.TabIndex = 9;
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progressBar4.Location = new System.Drawing.Point(179, 248);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(175, 23);
            this.progressBar4.TabIndex = 10;
            // 
            // progressBar5
            // 
            this.progressBar5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progressBar5.Location = new System.Drawing.Point(371, 248);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(175, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.Color.DarkViolet;
            this.progressBar6.Location = new System.Drawing.Point(581, 248);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(175, 23);
            this.progressBar6.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 277);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(175, 162);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(371, 277);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(175, 162);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(581, 277);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(175, 162);
            this.textBox6.TabIndex = 15;
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Location = new System.Drawing.Point(49, 71);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar1.TabIndex = 16;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(49, 306);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar2.TabIndex = 17;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnLimpiar1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSecuencial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress3);
            this.Controls.Add(this.progress2);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.btnMultihilos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultihilos;
        private System.Windows.Forms.ProgressBar progress1;
        private System.Windows.Forms.ProgressBar progress2;
        private System.Windows.Forms.ProgressBar progress3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.Button btnLimpiar2;
    }
}

