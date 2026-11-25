using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace Pr31
{
    public class ConcreteObserver : IObserver
    {
        private  ConcreteSubject Subject;
        public int State { get; set; }
        private ConcreteSubject subject;


        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }
        public void Update()
        {
            State = subject.State;
        }
    }
}
