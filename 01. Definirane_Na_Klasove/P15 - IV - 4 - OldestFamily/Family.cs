using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15___IV___4___OldestFamily
{
    public class Family
    {
		private List<Person> people=new List<Person>();

		public List<Person> People
		{
			get { return people; }
			set { people= value; }
		}

		public void AddMember(Person member)
		{
			people.Add(member);
		}

		public Person GetOldestMember()
		{
			people = people.OrderBy(x => x.Age).ToList();
			return people.LastOrDefault();
		}

    }
}
