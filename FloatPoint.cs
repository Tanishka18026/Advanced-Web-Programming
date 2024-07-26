class FloatP
{
	public void Calculate()
	{
		float a= 20.5F, b=6.4F;
		System.Console.WriteLine("a="+a);
		System.Console.WriteLine("b="+b);
		System.Console.WriteLine("a+b="+(a+b));
		System.Console.WriteLine("a-b="+(a-b));
		System.Console.WriteLine("a*b="+(a*b));
		System.Console.WriteLine("a/b="+(a/b));
		System.Console.WriteLine("a%b="+(a%b));
	}
}
class FloatPoint
{
	public static void Main()
	{
		FloatP obj=new FloatP();
		obj.Calculate();
	}
}