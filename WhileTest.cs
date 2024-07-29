using System;
class Demo
{
	public void Func()
	{
		int n=1;
		while(n<=10)
		{
			if(n%2==0)
			{
				n++;
			}
			else
			{
				Console.WriteLine(" "+n);
				n++;
			}
		}
	}
}

class WhileTest
{
	public static void Main()
	{
		Demo obj=new Demo();
		obj.Func();
	}
}