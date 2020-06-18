using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PatronBridge.Clases
{
    class MMDDAA : IDate
    {
        public MMDDAA()
        {
                
        }
        public string ayer()
        {
            return DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
        }

        public string hoy()
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }

        public string mañana()
        {
            return DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
        }
    }
}
