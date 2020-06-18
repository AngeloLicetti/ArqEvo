namespace Lab07_PatronEstado
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnArmar = new System.Windows.Forms.Button();
            this.btnDesarmar = new System.Windows.Forms.Button();
            this.btnReparar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnEndTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(12, 15);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(188, 20);
            this.txtEstado.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(220, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(220, 41);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnArmar
            // 
            this.btnArmar.Location = new System.Drawing.Point(220, 70);
            this.btnArmar.Name = "btnArmar";
            this.btnArmar.Size = new System.Drawing.Size(75, 23);
            this.btnArmar.TabIndex = 3;
            this.btnArmar.Text = "Armar";
            this.btnArmar.UseVisualStyleBackColor = true;
            this.btnArmar.Click += new System.EventHandler(this.btnArmar_Click);
            // 
            // btnDesarmar
            // 
            this.btnDesarmar.Location = new System.Drawing.Point(220, 99);
            this.btnDesarmar.Name = "btnDesarmar";
            this.btnDesarmar.Size = new System.Drawing.Size(75, 23);
            this.btnDesarmar.TabIndex = 4;
            this.btnDesarmar.Text = "Desarmar";
            this.btnDesarmar.UseVisualStyleBackColor = true;
            this.btnDesarmar.Click += new System.EventHandler(this.btnDesarmar_Click);
            // 
            // btnReparar
            // 
            this.btnReparar.Location = new System.Drawing.Point(220, 128);
            this.btnReparar.Name = "btnReparar";
            this.btnReparar.Size = new System.Drawing.Size(75, 23);
            this.btnReparar.TabIndex = 5;
            this.btnReparar.Text = "Reparar";
            this.btnReparar.UseVisualStyleBackColor = true;
            this.btnReparar.Click += new System.EventHandler(this.btnReparar_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(220, 157);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnEndTest
            // 
            this.btnEndTest.Location = new System.Drawing.Point(220, 186);
            this.btnEndTest.Name = "btnEndTest";
            this.btnEndTest.Size = new System.Drawing.Size(75, 23);
            this.btnEndTest.TabIndex = 7;
            this.btnEndTest.Text = "Untest";
            this.btnEndTest.UseVisualStyleBackColor = true;
            this.btnEndTest.Click += new System.EventHandler(this.btnEndTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 222);
            this.Controls.Add(this.btnEndTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnReparar);
            this.Controls.Add(this.btnDesarmar);
            this.Controls.Add(this.btnArmar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnArmar;
        private System.Windows.Forms.Button btnDesarmar;
        private System.Windows.Forms.Button btnReparar;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnEndTest;
    }
}

