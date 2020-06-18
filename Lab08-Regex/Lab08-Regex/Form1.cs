using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab08_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegexX_Click(object sender, EventArgs e)
        {
            MatchCollection mc = Regex.Matches(txtTexto.Text, txtRegex.Text);
            txtMatches.Text = mc.Count.ToString();
            foreach (Match m in mc)
            {
                lbMatches.Items.Add(m.ToString());
            }
        }

        private void btnEliminarBlancos_Click(object sender, EventArgs e)
        {
            AbstractFilter eliminarBlancos = new EliminarBlancos();
            txtEliminarBlancos.Text = eliminarBlancos.filtrar(txtTexto.Text);
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            AbstractFilter wordCount = new WordCount();
            txtEliminarBlancos.Text = wordCount.filtrar(txtTexto.Text);
        }
    }
}
