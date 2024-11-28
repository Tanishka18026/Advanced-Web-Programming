class Ex
{
    // Define the delegate
    public delegate void SimpleDelegate();

    // Define the event based on the delegate
    public event SimpleDelegate MyEvent;

    // First function to be called
    public static void CallingFunction()
    {
        System.Console.WriteLine("First Function Called.....");
    }

    // Second function to be called
    public static void SecFunction()
    {
        System.Console.WriteLine("Second Function Called.....");
    }

    // Method to demonstrate delegate and event usage
    public void Fun()
    {
        // Adding event handlers
        MyEvent += new SimpleDelegate(CallingFunction);
        MyEvent += new SimpleDelegate(SecFunction);

        // Check if there are any subscribers before invoking
        if (MyEvent != null)
        {
            MyEvent.Invoke();
        }
    }
}

class Prac2c1
{
    public static void Main(string[] args)
    {
        Ex obj = new Ex();
        obj.Fun();
        System.Console.ReadLine();
    }
}
