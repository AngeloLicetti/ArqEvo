namespace Lab09_TuberiasYFiltros
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
            this.cbEliminarBlancos = new System.Windows.Forms.CheckBox();
            this.cbWordCount = new System.Windows.Forms.CheckBox();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lbFiltros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbEliminarBlancos
            // 
            this.cbEliminarBlancos.AutoSize = true;
            this.cbEliminarBlancos.Location = new System.Drawing.Point(69, 43);
            this.cbEliminarBlancos.Name = "cbEliminarBlancos";
            this.cbEliminarBlancos.Size = new System.Drawing.Size(101, 17);
            this.cbEliminarBlancos.TabIndex = 0;
            this.cbEliminarBlancos.Text = "Elminar Blancos";
            this.cbEliminarBlancos.UseVisualStyleBackColor = true;
            this.cbEliminarBlancos.CheckedChanged += new System.EventHandler(this.cbEliminarBlancos_CheckedChanged);
            // 
            // cbWordCount
            // 
            this.cbWordCount.AutoSize = true;
            this.cbWordCount.Location = new System.Drawing.Point(69, 67);
            this.cbWordCount.Name = "cbWordCount";
            this.cbWordCount.Size = new System.Drawing.Size(83, 17);
            this.cbWordCount.TabIndex = 1;
            this.cbWordCount.Text = "Word Count";
            this.cbWordCount.UseVisualStyleBackColor = true;
            this.cbWordCount.CheckedChanged += new System.EventHandler(this.cbWordCount_CheckedChanged);
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(69, 91);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(66, 17);
            this.cbReverse.TabIndex = 2;
            this.cbReverse.Text = "Reverse";
            this.cbReverse.UseVisualStyleBackColor = true;
            this.cbReverse.CheckedChanged += new System.EventHandler(this.cbReverse_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(421, 200);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(269, 109);
            this.txtOutput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(421, 27);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(269, 109);
            this.txtInput.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(165, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(517, 148);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lbFiltros
            // 
            this.lbFiltros.FormattingEnabled = true;
            this.lbFiltros.Location = new System.Drawing.Point(69, 214);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(256, 95);
            this.lbFiltros.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 361);
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cbReverse);
            this.Controls.Add(this.cbWordCount);
            this.Controls.Add(this.cbEliminarBlancos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEliminarBlancos;
        private System.Windows.Forms.CheckBox cbWordCount;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListBox lbFiltros;
    }
}

