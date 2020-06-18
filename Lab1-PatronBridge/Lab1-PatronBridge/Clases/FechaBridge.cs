using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PatronBridge.Clases
{
    class FechaBridge : IDate
    {
        IDate iDate;

        public FechaBridge(IDate iDate)
        {
            this.iDate = iDate;
        }

        public string ayer()
        {
            return iDate.ayer();
        }

        public string hoy()
        {
            return iDate.hoy();
        }

        public string mañana()
        {
            return iDate.mañana();
        }
    }
}
