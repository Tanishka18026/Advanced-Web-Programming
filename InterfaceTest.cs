using System;
interface Addition
{
	int Add();
}
interface Multiplication
{
	int Mul();
}
class Computation: Addition, Multiplication
{
	int x, y;	
	public Computation(int x, int y)
	{
		this.x=x;
		this.y=y;
	}
	public int Add()
	{
		return(x=y);
	}
	public int Mul()
	{
		return(x=y);
	}
} 
class InterfaceTest
{
	public static void Main()
	{
		Computation com= new Computation(10,20);
		Addition add=(Addition)com;
		Console.WriteLine("Sum=" +add.Add());
		 Multiplication mul=( Multiplication)com;
		Console.WriteLine("Mul=" +mul.Mul());
	}
}