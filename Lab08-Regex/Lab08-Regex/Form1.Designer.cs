namespace Lab08_Regex
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
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnRegexX = new System.Windows.Forms.Button();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.txtEliminarBlancos = new System.Windows.Forms.TextBox();
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.btnEliminarBlancos = new System.Windows.Forms.Button();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(78, 58);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(423, 20);
            this.txtRegex.TabIndex = 0;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(78, 94);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(423, 80);
            this.txtTexto.TabIndex = 1;
            // 
            // btnRegexX
            // 
            this.btnRegexX.Location = new System.Drawing.Point(426, 189);
            this.btnRegexX.Name = "btnRegexX";
            this.btnRegexX.Size = new System.Drawing.Size(75, 23);
            this.btnRegexX.TabIndex = 7;
            this.btnRegexX.Text = "Regex X";
            this.btnRegexX.UseVisualStyleBackColor = true;
            this.btnRegexX.Click += new System.EventHandler(this.btnRegexX_Click);
            // 
            // txtMatches
            // 
            this.txtMatches.Location = new System.Drawing.Point(229, 212);
            this.txtMatches.Name = "txtMatches";
            this.txtMatches.Size = new System.Drawing.Size(101, 20);
            this.txtMatches.TabIndex = 3;
            // 
            // txtEliminarBlancos
            // 
            this.txtEliminarBlancos.Location = new System.Drawing.Point(78, 328);
            this.txtEliminarBlancos.Multiline = true;
            this.txtEliminarBlancos.Name = "txtEliminarBlancos";
            this.txtEliminarBlancos.Size = new System.Drawing.Size(423, 80);
            this.txtEliminarBlancos.TabIndex = 8;
            // 
            // lbMatches
            // 
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.Location = new System.Drawing.Point(78, 212);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(120, 95);
            this.lbMatches.TabIndex = 9;
            // 
            // btnEliminarBlancos
            // 
            this.btnEliminarBlancos.Location = new System.Drawing.Point(426, 230);
            this.btnEliminarBlancos.Name = "btnEliminarBlancos";
            this.btnEliminarBlancos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarBlancos.TabIndex = 7;
            this.btnEliminarBlancos.Text = "Elim Blancos";
            this.btnEliminarBlancos.UseVisualStyleBackColor = true;
            this.btnEliminarBlancos.Click += new System.EventHandler(this.btnEliminarBlancos_Click);
            // 
            // btnWordCount
            // 
            this.btnWordCount.Location = new System.Drawing.Point(426, 268);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(75, 23);
            this.btnWordCount.TabIndex = 7;
            this.btnWordCount.Text = "Word Count";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 449);
            this.Controls.Add(this.lbMatches);
            this.Controls.Add(this.txtEliminarBlancos);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.btnEliminarBlancos);
            this.Controls.Add(this.btnRegexX);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtRegex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnRegexX;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.TextBox txtEliminarBlancos;
        private System.Windows.Forms.ListBox lbMatches;
        private System.Windows.Forms.Button btnEliminarBlancos;
        private System.Windows.Forms.Button btnWordCount;
    }
}

