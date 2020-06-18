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

        private void txtRegex_TextChanged(object sender, EventArgs e)
        {
            MatchCollection mc = Regex.Matches(txtTexto.Text, txtRegex.Text);
            txtMatches.Text = mc.Count.ToString();
        }
    }
}
