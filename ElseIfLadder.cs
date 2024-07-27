using System;


class func
{
	public void Calculate()
	{
		int[] rollNumber = { 111, 222, 333, 444 };
        int[] marks = { 81, 75, 43, 58 };

        for (int i = 0; i < rollNumber.Length; i++)
        {
            if (marks[i] > 79)
                Console.WriteLine(rollNumber[i] + " Honours");
            else if (marks[i] > 59)
                Console.WriteLine(rollNumber[i] + " I Division");
            else if (marks[i] > 49)
                Console.WriteLine(rollNumber[i] + " II Division");
            else
                Console.WriteLine(rollNumber[i] + " FAIL");
        }
	}
}
class ElseIfLadder
{
    public static void Main()
    {
         func obj=new func();
	 obj.Calculate();
    }
}
