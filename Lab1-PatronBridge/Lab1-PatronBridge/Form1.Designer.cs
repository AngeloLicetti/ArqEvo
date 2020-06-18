namespace Lab1_PatronBridge
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
            this.rbDDMMAA = new System.Windows.Forms.RadioButton();
            this.rbBigEndian = new System.Windows.Forms.RadioButton();
            this.rbMMDDAA = new System.Windows.Forms.RadioButton();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnMañana = new System.Windows.Forms.Button();
            this.btnAyer = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbDDMMAA
            // 
            this.rbDDMMAA.AutoSize = true;
            this.rbDDMMAA.Location = new System.Drawing.Point(112, 58);
            this.rbDDMMAA.Name = "rbDDMMAA";
            this.rbDDMMAA.Size = new System.Drawing.Size(73, 17);
            this.rbDDMMAA.TabIndex = 0;
            this.rbDDMMAA.TabStop = true;
            this.rbDDMMAA.Text = "DDMMAA";
            this.rbDDMMAA.UseVisualStyleBackColor = true;
            // 
            // rbBigEndian
            // 
            this.rbBigEndian.AutoSize = true;
            this.rbBigEndian.Location = new System.Drawing.Point(112, 93);
            this.rbBigEndian.Name = "rbBigEndian";
            this.rbBigEndian.Size = new System.Drawing.Size(76, 17);
            this.rbBigEndian.TabIndex = 1;
            this.rbBigEndian.TabStop = true;
            this.rbBigEndian.Text = "Big Endian";
            this.rbBigEndian.UseVisualStyleBackColor = true;
            // 
            // rbMMDDAA
            // 
            this.rbMMDDAA.AutoSize = true;
            this.rbMMDDAA.Location = new System.Drawing.Point(112, 127);
            this.rbMMDDAA.Name = "rbMMDDAA";
            this.rbMMDDAA.Size = new System.Drawing.Size(73, 17);
            this.rbMMDDAA.TabIndex = 2;
            this.rbMMDDAA.TabStop = true;
            this.rbMMDDAA.Text = "MMDDAA";
            this.rbMMDDAA.UseVisualStyleBackColor = true;
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(30, 195);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(75, 23);
            this.btnHoy.TabIndex = 3;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnMañana
            // 
            this.btnMañana.Location = new System.Drawing.Point(131, 195);
            this.btnMañana.Name = "btnMañana";
            this.btnMañana.Size = new System.Drawing.Size(75, 23);
            this.btnMañana.TabIndex = 4;
            this.btnMañana.Text = "Mañana";
            this.btnMañana.UseVisualStyleBackColor = true;
            this.btnMañana.Click += new System.EventHandler(this.btnMañana_Click);
            // 
            // btnAyer
            // 
            this.btnAyer.Location = new System.Drawing.Point(244, 195);
            this.btnAyer.Name = "btnAyer";
            this.btnAyer.Size = new System.Drawing.Size(75, 23);
            this.btnAyer.TabIndex = 5;
            this.btnAyer.Text = "Ayer";
            this.btnAyer.UseVisualStyleBackColor = true;
            this.btnAyer.Click += new System.EventHandler(this.btnAyer_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(131, 253);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 306);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnAyer);
            this.Controls.Add(this.btnMañana);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.rbMMDDAA);
            this.Controls.Add(this.rbBigEndian);
            this.Controls.Add(this.rbDDMMAA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDDMMAA;
        private System.Windows.Forms.RadioButton rbBigEndian;
        private System.Windows.Forms.RadioButton rbMMDDAA;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnMañana;
        private System.Windows.Forms.Button btnAyer;
        private System.Windows.Forms.TextBox txtFecha;
    }
}

