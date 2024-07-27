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
            default:
                x = y - m;
                break;
            case 2:
                x = y + m;
                goto default;
            case 1:
                x = y;
                goto case 2;
        }

        Console.WriteLine("Value of x: " + x);
	}
}
class Switch3
{
    static void Main()
    {
        func obj=new func();
	obj.Calculate();
    }
}
