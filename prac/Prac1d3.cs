class Demo
{
    public void func()
    {
	
	char c=System.Convert.ToChar(System.Console.ReadLine());
	if(c == 'A' ||c == 'E' ||c == 'I' ||c == 'O' ||c == 'U' ||c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u')
	{
		System.Console.WriteLine("{0} is a Vowel",c);
	}
	else
	{
		System.Console.WriteLine("{0} is a consonant",c);
	}
	
    }
}
class Prac1d3
{
    public static void Main(string[] args)
    {
	Demo obj1=new Demo();
	
	obj1.func();
    }
}