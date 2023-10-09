
internal class Program
{
	private static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine(Faktorial(n));
	}

	private static int Faktorial(int n)
	{
		if(n == 1)
		{
			return 1;
		}
        else
        {
            return n * Faktorial(n-1);
        }
    }
}