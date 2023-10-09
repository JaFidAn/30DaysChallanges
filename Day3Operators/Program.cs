internal class Program
{
	private static void Main(string[] args)
	{
		solve(200, 20, 8);
	}

	public static void solve(double meal_cost, int tip_percent, int tax_percent)
	{
		double tipCost = meal_cost * tip_percent / 100;
		double taxCost = meal_cost * tax_percent / 100;
		double totalCost = meal_cost + tipCost + taxCost;

		Console.WriteLine(Math.Round(totalCost));
	}
}