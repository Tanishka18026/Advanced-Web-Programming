class Demo
{
	public void Func()
	{
		int[] arrayInt ={11,22,33,44};
		foreach( int m in arrayInt)
		{	
			System.Console.WriteLine(" "+ m);
		}
		System.Console.WriteLine();
	}
}
class ForeachTest
{
	public static void Main()
	{
		Demo obj=new Demo();
		obj.Func();
	}
}
