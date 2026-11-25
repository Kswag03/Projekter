using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pr31
{
    public class ConcreteSubject : ISubject
    {
        private int state;
        public int State
        {
            get { return state; }
            set 
            {
                state = value;
                this.Notify();
            }
        }

        public void Attach(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void Detach(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}

