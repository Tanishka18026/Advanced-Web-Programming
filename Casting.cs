class Cast
{
	public void Calculate()
	{
		float sum;
		int i;
		sum=0.0F;
		for(i=1;1<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.WriteLine("i="+i);
			System.Console.WriteLine("Sum= "+sum);
		
	}
}
class Casting
{
	public static void Main()
	{
		Cast obj=new Cast();
		obj.Calculate();
	}
}