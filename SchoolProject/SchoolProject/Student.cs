using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Student : Person
    {
        public Student(string name, int age,int grade) 
            : base(name, age)
        {
            this.Grade = grade;
        }
        public int Grade { get; private set; }
        public override string ToString()
        {
            return $"Ученик: {Name}, Възраст: {Age}, Клас: {Grade}";
        }
    }
}
