using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Iterator
{
    abstract class AbstractIterator
    {
        public AbstractIterator()
        {

        }

        public abstract Object Top();
        public abstract Object Bottom();
        public abstract Object Next();
        public abstract Object Previous();
        public abstract Object Central();

    }
}
