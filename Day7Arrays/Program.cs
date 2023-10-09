
internal class Program
{
	private static void Main(string[] args)
	{
		List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
		ReversePrint(arr);
	}

	private static void ReversePrint(List<int> arr)
	{
		int length = arr.Count;
		for(int i = length - 1; i >= 0; i--)
		{
			if(i !=0)
			{
				Console.Write(arr[i] + " ");
			}
			else
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}