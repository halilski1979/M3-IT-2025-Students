using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Teacher : Person
    {
        public Teacher(string name, int age,string subject) 
            : base(name, age)
        {
            this.Subject = subject;
        }
        public string Subject { get; private set; }
        public override string ToString()
        {
            return $"Учител: {Name}, Възраст: {Age}, Предмет: {Subject}";
        }
    }
}
