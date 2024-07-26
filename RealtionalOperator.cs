class RO
{
	public void Calculate()
	{
		float a= 15.0F, b=20.75F, c=15.0F;
		System.Console.WriteLine("a="+a);
		System.Console.WriteLine("b="+b);
		System.Console.WriteLine("c="+c);
		System.Console.WriteLine("a<b is "+(a<b));
		System.Console.WriteLine("a>b is "+(a>b));
		System.Console.WriteLine("a==c is "+(a==c));
		System.Console.WriteLine("a<=c is "+(a<=c));
		System.Console.WriteLine("a>=b is "+(a>=b));
		System.Console.WriteLine("b!=c is "+(b!=c));
		System.Console.WriteLine("b==a+c is "+(b==a+c));

	}
}
class RealtionalOperator
{
	public static void Main()
	{
		RO obj=new RO();
		obj.Calculate();
	}
}