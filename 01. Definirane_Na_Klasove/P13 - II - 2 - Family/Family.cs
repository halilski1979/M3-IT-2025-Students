using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___II___2___Family
{
    public class Family
    {
        public List<Person> families=new List<Person>();

       public void AddMember(Person member)
        {
            families.Add(member);
        }


       public void SortName()
        {
            families = families.OrderBy(x=>x.Name).ToList();
        }

        public void SortAge()
        {
            families = families.OrderBy(x => x.Age).ToList();
        }
        
        public void Print()
        {       
            
            foreach (Person item in families)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
