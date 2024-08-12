using System;
class Number
{
	private int number;
	public int Anumber
	{ 
		get
		{
			return(number);
		}
		set
		{
			number=value;
		}
	}
}
class PropertyTest
{ 	
	public static void Main()
	{
		Number n=new Number();
		n.Anumber=100;
		int m=n.Anumber;
		Console.WriteLine("Number" +m);
	}
}