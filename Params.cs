
class Params
{
	static void Parray(params int [] arr)
	{
		System.Console.WriteLine("Array elements are:");
		foreach(int i in arr)
			System.Console.WriteLine(" "+i);
		System.Console.WriteLine();
	}

	public static void Main()
	{
		int [] x={11,22,33};
		Parray(x);
		Parray();
		Parray(100,200);

	}
}
