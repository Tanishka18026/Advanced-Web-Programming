using System;
class func
{
	public void Calculate()
	{
        int x, y, m;

        // Example values for demonstration
        y = 10;
        m = 1;

        switch (m)
        {
            case 1:
                x = y;
                goto case 2;
            case 2:
                x = y + m;
                goto default;
            default:
                x = y - m ;
                break;
        }

        Console.WriteLine("Value of x: " + x);
	}
}
class Switch2
{
     public static void Main()
    {
        func obj=new func();
	obj.Calculate();
        
    }
}
