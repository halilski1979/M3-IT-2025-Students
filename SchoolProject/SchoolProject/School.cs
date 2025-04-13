using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class School
    {
        public string Name { get; private set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public School(string name) 
        { 
        this.Name = name;
        this.Students = new List<Student>();
        this.Teachers=new List<Teacher>();
        }
        //Methods
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }//end1
        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }//end2
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Училище {Name}");
            sb.AppendLine("Ученици:");
            foreach (Student student in this.Students)
            {
                sb.AppendLine(student.ToString());
            }
            sb.AppendLine("Учители:");
            foreach (Teacher teacher in Teachers)
            {
                sb.AppendLine(teacher.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
