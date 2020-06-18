using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PatronBridge.Clases
{
    class DDMMAA : IDate
    {
        public DDMMAA()
        {

        }
        public string ayer()
        {
            return DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
        }

        public string hoy()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string mañana()
        {
            return DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
        }
    }
}
