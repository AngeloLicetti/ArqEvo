using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Iterator
{
    class MiListBox : ListBox
    {
        private Iterator iterator;
        public MiListBox()
        {
        }

        public Iterator getIterator()
        {
            return iterator;
        }
    }
}
