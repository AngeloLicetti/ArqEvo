using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PatronBridge.Clases
{
    class BigEndian : IDate
    {
        public BigEndian()
        {

        }
        public string ayer()
        {
            return DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd");
        }

        public string hoy()
        {
            return DateTime.Now.ToString("yyyy/MM/dd");
        }

        public string mañana()
        {
            return DateTime.Now.AddDays(1).ToString("yyyy/MM/dd");
        }
    }
}
