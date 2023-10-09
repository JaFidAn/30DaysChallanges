internal class Program
{
	private static void Main(string[] args)
	{
		Solution(5);
	}

	public static void Solution(int n)
	{
		for(int i = 1; i <= 10; i++)
		{
			Console.WriteLine($"{n} x {i} = {n*i}");
		}
	}
}