class Cel
{
	public static void Main(string[] args)
	{
		float F=System.Single.Parse(args [0]);
		float C= (float)((F-32)/1.8);
		System.Console.WriteLine(C);
	}
}