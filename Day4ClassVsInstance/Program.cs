using Day4ClassVsInstance;

internal class Program
{
	private static void Main(string[] args)
	{
		Person person = new Person(12);
		person.amIOld();
		person.yearPasses();
	}
}