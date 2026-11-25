using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Pr31
{
    public class Student : IObserver
    {
        private Academy subject;
        public string Message { get; set; }
        public string Name { get; }
        public Student(Academy subject, string name )
        {
            this.subject = subject;
            Name = name;
        }

        public void Update()
        {
            Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra acadamiet {subject.Name}");
        }
    }
}
