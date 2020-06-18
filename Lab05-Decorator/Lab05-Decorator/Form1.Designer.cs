namespace Lab05_Decorator
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
            this.cbQueso = new System.Windows.Forms.CheckBox();
            this.cbAnchoas = new System.Windows.Forms.CheckBox();
            this.cbJalapeño = new System.Windows.Forms.CheckBox();
            this.cbTocino = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnPizzaBase = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbQueso
            // 
            this.cbQueso.AutoSize = true;
            this.cbQueso.Location = new System.Drawing.Point(32, 84);
            this.cbQueso.Name = "cbQueso";
            this.cbQueso.Size = new System.Drawing.Size(57, 17);
            this.cbQueso.TabIndex = 0;
            this.cbQueso.Text = "Queso";
            this.cbQueso.UseVisualStyleBackColor = true;
            this.cbQueso.CheckedChanged += new System.EventHandler(this.cbQueso_CheckedChanged);
            // 
            // cbAnchoas
            // 
            this.cbAnchoas.AutoSize = true;
            this.cbAnchoas.Location = new System.Drawing.Point(153, 84);
            this.cbAnchoas.Name = "cbAnchoas";
            this.cbAnchoas.Size = new System.Drawing.Size(68, 17);
            this.cbAnchoas.TabIndex = 1;
            this.cbAnchoas.Text = "Anchoas";
            this.cbAnchoas.UseVisualStyleBackColor = true;
            this.cbAnchoas.CheckedChanged += new System.EventHandler(this.cbAnchoas_CheckedChanged);
            // 
            // cbJalapeño
            // 
            this.cbJalapeño.AutoSize = true;
            this.cbJalapeño.Location = new System.Drawing.Point(32, 117);
            this.cbJalapeño.Name = "cbJalapeño";
            this.cbJalapeño.Size = new System.Drawing.Size(69, 17);
            this.cbJalapeño.TabIndex = 2;
            this.cbJalapeño.Text = "Jalapeño";
            this.cbJalapeño.UseVisualStyleBackColor = true;
            this.cbJalapeño.CheckedChanged += new System.EventHandler(this.cbJalapeño_CheckedChanged);
            // 
            // cbTocino
            // 
            this.cbTocino.AutoSize = true;
            this.cbTocino.Location = new System.Drawing.Point(153, 117);
            this.cbTocino.Name = "cbTocino";
            this.cbTocino.Size = new System.Drawing.Size(59, 17);
            this.cbTocino.TabIndex = 3;
            this.cbTocino.Text = "Tocino";
            this.cbTocino.UseVisualStyleBackColor = true;
            this.cbTocino.CheckedChanged += new System.EventHandler(this.cbTocino_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(84, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPizzaBase
            // 
            this.btnPizzaBase.Location = new System.Drawing.Point(84, 30);
            this.btnPizzaBase.Name = "btnPizzaBase";
            this.btnPizzaBase.Size = new System.Drawing.Size(75, 23);
            this.btnPizzaBase.TabIndex = 5;
            this.btnPizzaBase.Text = "Base Jamon";
            this.btnPizzaBase.UseVisualStyleBackColor = true;
            this.btnPizzaBase.Click += new System.EventHandler(this.btnPizzaBase_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(70, 209);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 241);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnPizzaBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbTocino);
            this.Controls.Add(this.cbJalapeño);
            this.Controls.Add(this.cbAnchoas);
            this.Controls.Add(this.cbQueso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbQueso;
        private System.Windows.Forms.CheckBox cbAnchoas;
        private System.Windows.Forms.CheckBox cbJalapeño;
        private System.Windows.Forms.CheckBox cbTocino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnPizzaBase;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

