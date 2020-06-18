using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Memento
{
    class Guardian
    {
        private Stack<Memento> mementoStack = new Stack<Memento>();

        public void push(Memento m)
        {
            mementoStack.Push(m);
        }

        public Memento estadoActual()
        {
            if (mementoStack.Count == 0)
            {
                return null;
            }
            return mementoStack.Peek();
        }

        public void pop()
        {
            if (mementoStack.Count !=1)
            {
                mementoStack.Pop();
            }
        }
    }
}
