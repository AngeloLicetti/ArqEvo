namespace Lab03_Iterator
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
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCentral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.mlbLista = new Lab03_Iterator.MiListBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.rbImpar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(329, 40);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 1;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(329, 82);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(75, 23);
            this.btnBottom.TabIndex = 2;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(329, 125);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(329, 167);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnCentral
            // 
            this.btnCentral.Location = new System.Drawing.Point(329, 213);
            this.btnCentral.Name = "btnCentral";
            this.btnCentral.Size = new System.Drawing.Size(75, 23);
            this.btnCentral.TabIndex = 5;
            this.btnCentral.Text = "Central";
            this.btnCentral.UseVisualStyleBackColor = true;
            this.btnCentral.Click += new System.EventHandler(this.btnCentral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected:";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(71, 311);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(100, 20);
            this.txtSelected.TabIndex = 9;
            // 
            // mlbLista
            // 
            this.mlbLista.FormattingEnabled = true;
            this.mlbLista.Items.AddRange(new object[] {
            "Alarcon",
            "Caldas",
            "Candela",
            "De la cruz",
            "Espinoza",
            "Farfan",
            "Gamarra",
            "Lau",
            "Licetti",
            "Miranda",
            "Mora",
            "Mujica",
            "ParedesF",
            "ParedesM",
            "Rivera",
            "Troncos",
            "Villanueva"});
            this.mlbLista.Location = new System.Drawing.Point(71, 26);
            this.mlbLista.Name = "mlbLista";
            this.mlbLista.Size = new System.Drawing.Size(118, 238);
            this.mlbLista.TabIndex = 11;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(329, 282);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(67, 17);
            this.rbNormal.TabIndex = 12;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "rbNormal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbPar
            // 
            this.rbPar.AutoSize = true;
            this.rbPar.Location = new System.Drawing.Point(329, 313);
            this.rbPar.Name = "rbPar";
            this.rbPar.Size = new System.Drawing.Size(50, 17);
            this.rbPar.TabIndex = 13;
            this.rbPar.Text = "rbPar";
            this.rbPar.UseVisualStyleBackColor = true;
            this.rbPar.CheckedChanged += new System.EventHandler(this.rbPar_CheckedChanged);
            // 
            // rbImpar
            // 
            this.rbImpar.AutoSize = true;
            this.rbImpar.Location = new System.Drawing.Point(329, 352);
            this.rbImpar.Name = "rbImpar";
            this.rbImpar.Size = new System.Drawing.Size(60, 17);
            this.rbImpar.TabIndex = 14;
            this.rbImpar.Text = "rbImpar";
            this.rbImpar.UseVisualStyleBackColor = true;
            this.rbImpar.CheckedChanged += new System.EventHandler(this.rbImpar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 381);
            this.Controls.Add(this.rbImpar);
            this.Controls.Add(this.rbPar);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.mlbLista);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCentral);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelected;
        private MiListBox mlbLista;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.RadioButton rbImpar;
    }
}

