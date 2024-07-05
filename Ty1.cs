class Ty1
{	
	public static void Main(string[] args)
	{
		int a=10;
		object ob1=(object)a;
		System.Console.WriteLine(ob1);

		int b= 10;
		object ob2=b;
		int c=(int)ob2;
		System.Console.WriteLine(ob2);
		System.Console.WriteLine(c);
	}
}