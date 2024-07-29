
class Demo
{
	public void Func()
	{
		int row, column,y;
		row=1;	
		System.Console.WriteLine("Multiplication Table \n");
		do
		{
			column=1;
			do
			{
				y=row*column;
				System.Console.WriteLine(" "+y);
				column=column+1;
			}
			while(column<=3);
			System.Console.WriteLine("\n");
			row=row+1;
		}
		while(row<=3);
	}
}
class DoWhileTest
{
	public static void Main()
	{
		Demo obj=new Demo();
		obj.Func();
	}
}