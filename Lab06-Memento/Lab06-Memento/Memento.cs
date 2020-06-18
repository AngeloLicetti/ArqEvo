using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Memento
{
    class Memento
    {
        private Color color;
        private string nombreColor;

        public Memento(Color color, string nombreColor)
        {
            this.Color = color;
            this.NombreColor = nombreColor;
        }

        public Color Color { get => color; set => color = value; }
        public string NombreColor { get => nombreColor; set => nombreColor = value; }
    }
}
