using System;
delegate int Ari(int x, int y);
class MathOperation
{
	public static int Add(int a, int b)
	{ 
		return(a+b);
	}
	public static int Sub(int a, int b)
	{ 
		return(a-b);
	}
}
class DelegateTest
{ 	
	public static void Main()
	{
		Ari op1=new Ari(MathOperation.Add);
		Ari op2=new Ari(MathOperation.Sub);
		int res1=op1(200,100);
		int res2=op2(200,100);
		Console.WriteLine(res1);
		Console.WriteLine(res2);

	}
}