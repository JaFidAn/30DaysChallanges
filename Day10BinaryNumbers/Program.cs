internal class Program
{
	private static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine().Trim());
		int reminder = 0;
		int count = 0;
		int max = 0;

		while (n > 0)
		{
			reminder = n % 2;
			n = n / 2;

			if(reminder == 1)
			{
				count++;
				max = Math.Max(max, count);
			}
            else
            {
				count = 0;
            }
        }

		Console.WriteLine(max);
	}
}