using System;
class func
{
	public void Calculate()
	{
	int i, count, count1, count2;
        float[] weight = { 45.0F, 55.0F, 47.0F, 51.0F, 54.0F };
        float[] height = { 176.5F, 174.2F, 168.0F, 170.7F, 169.0F };
        count = 0;
        count1 = 0;
        count2 = 0;

        for (i = 0; i < weight.Length; i++) // Use weight.Length to iterate over all elements
        {
            if (weight[i] < 50.0 && height[i] > 170.0)
            {
                count1++; // Executed when condition is true
            }
            count++; // Always executed
        }

        count2 = count - count1;
        Console.WriteLine("Number of persons with weight < 50 and height > 170 = " + count1);
        Console.WriteLine("Others count = " + count2);
	}
}
class IfTest
{
    public static void Main()
    {
	func obj=new func();
	obj.Calculate();
     }
}
