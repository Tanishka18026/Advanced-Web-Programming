class Demo
{
	public void funtion()
	{
		System.Console.Write("Enter a number: ");
		int n=System.Convert.ToInt32(System.Console.ReadLine());	
		int a = 0;
        	for (int i = 1; i <= n; i++)
		 {
           		 if (n % i == 0) 
			{
              			a++;
            		}
         	 }
        	 if (a == 2) 
		 {
            	 	System.Console.WriteLine("{0} is a Prime Number", n);
         	 } 
		 else 
		 {
            		System.Console.WriteLine("{0} is not a Prime Number",n);
         	 }
	}
}
class Prac1d2
{
	public static void Main(string[] args)
	{
		Demo obj1=new Demo();
		obj1.funtion();
	}
}