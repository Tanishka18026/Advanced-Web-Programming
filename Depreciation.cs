class Depreciation
{
	public static void Main(string[] args)
	{
		int depreciation,purchaseprice, salvage, year;
		purchaseprice=System.Int32.Parse(args[0]);
		salvage=System.Int32.Parse(args[1]);
		year=System.Int32.Parse(args[2]);
		depreciation= salvage-purchaseprice/year;
		System.Console.WriteLine(depreciation);
	}
}