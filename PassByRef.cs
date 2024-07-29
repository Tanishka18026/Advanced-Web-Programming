class PassByRef
{
	static void Swap(ref int x, ref int y)
	{
		int temp=x;
		x=y;
		y=temp;
	}
	public static void Main()
	{
		int m=100;
		int n=200;
		System.Console.WriteLine("Before Swapping");
		System.Console.WriteLine("m= "+m);
		System.Console.WriteLine("n= "+n);
		Swap(ref m, ref n);
		System.Console.WriteLine("Before Swapping");
		System.Console.WriteLine("m= "+m);
		System.Console.WriteLine("n= "+n);

	}
}
