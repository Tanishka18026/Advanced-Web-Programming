using System;
class func
{
	public void Calculate()
	{
	int x, y, m;

        // Example values for demonstration
        y = 10;
        m = 2;

        switch (m)
        {
            case 1:
                x = y;
                break;
            case 2:
                x = y + m;
                break;
            default:
                x = y;
                break;
        }

        Console.WriteLine("Value of x: " + x);
	}
}
class Swich1
{
    static void Main()
    {
       func obj=new func();
	obj.Calculate();
    }
}
