
class MT
{
	public void Calculate()
	{
		System.Console.WriteLine("Sines of angles from 0 to 90 dgrees");
		for(double theta=0.0; theta<=90.00;theta+=15)
		{
			double x=System.Math.Sin (theta* System.Math.PI/180);
			System.Console.WriteLine("Sin" +theta);
			System.Console.WriteLine("={0:F4}" +x);
		}
	}
}
class MathTest
{
	public static void Main()
	{
		MT obj=new MT();
		obj.Calculate();
	}
}