using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ClassVsInstance
{
	public class Person
	{
		public int age;

		public Person(int initialAge)
		{
			if (initialAge > 0)
			{
				age = initialAge;
			}
			else
			{
				age = 0;
				Console.WriteLine("Age is not valid, setting age to 0.");
			}
		}

		public void amIOld()
		{
			if (age < 13)
			{
				Console.WriteLine("You are Young");
			}
			else if (age >= 13 && age < 18)
			{
				Console.WriteLine("Your are Teenager");
			}
			else
			{
				Console.WriteLine("You are Old");
			}
		}

		public void yearPasses()
		{
			age++;
			Console.WriteLine(age);
		}
	}
}
