using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31
{
    public class Academy : ISubject
    {
        public string Name { get; }
        private string message;
        public string Message 
        {
            get { return message; }
            set { message = value; Notify(); }
        }

        public Academy(string name)
        {
            Name = name; 
        }

        List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }
        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
