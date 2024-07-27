using System;
class func
{
	public void Calculate()
	{
		int a = 325, b = 712, c = 478;

        Console.Write("Largest value is: ");

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
	}
}
class IfElseNesting
{
    public static void Main()
    {
        func obj=new func();
	obj.Calculate();

    }
}
