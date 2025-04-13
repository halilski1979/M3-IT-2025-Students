namespace SchoolProject
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("Въведи име на училище:");
                string name = Console.ReadLine();
                School school = new School(name);
                Console.WriteLine("*Изберете операция*");
                Console.WriteLine("s- въвеждане на ученик");
                Console.WriteLine("t-въвеждане на учител");
                Console.WriteLine("v- информация за училището");
                Console.WriteLine("q- излизане от приложението");
                Console.Write("Въведете код: ");
                string code=Console.ReadLine();
                while (code!="q")
                {
                    switch (code)
                    {
                        case "s":
                            Console.Write("Име:");
                            string nameS=Console.ReadLine();
                            Console.Write("Години: ");
                            int ageS=int.Parse(Console.ReadLine());
                            Console.Write("клас: ");
                            int grade=int.Parse(Console.ReadLine());
                            Student s=new Student(nameS, ageS, grade);
                            school.AddStudent(s);
                            Console.WriteLine($"Ученика {name} е записан успешно!");
                            break;
                        case "t":
                            Console.Write("Име:");
                            string nameT=Console.ReadLine();
                            Console.Write("Години: ");
                            int ageT=int.Parse (Console.ReadLine());
                            Console.Write("Предмет: ");
                            string subject=Console.ReadLine();
                            Teacher t=new Teacher(nameT, ageT, subject);
                            school.AddTeacher(t);
                            Console.WriteLine($"Учителят {nameT} е назначен в училище!");
                            break;
                        case "v":
                            Console.Clear();
                            Console.WriteLine(school.Print());
                            break;
                            default: Console.WriteLine("Операцията е невалидна!");
                            break;
                    }
                    Console.Write("Въведи код: ");
                    code = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("ВИЕ ИЗЛЯЗОХТЕ УСПЕШНО ОТ СИСТЕМАТА!");

            }
			catch (Exception e)
			{

                Console.WriteLine(e.Message);
            }
        }
    }
}
