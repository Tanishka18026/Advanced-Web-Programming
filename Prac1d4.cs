class NameProcessor
{
    // Method to process and display names
    public void DisplayNames(string[] names)
    {
        foreach (string name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an array of names
        string[] names = { "Alice", "Bob", "Charlie", "Diana" };

        // Create an object of the NameProcessor class
        NameProcessor nameProcessor = new NameProcessor();

        // Call the DisplayNames method to process and display the names
        nameProcessor.DisplayNames(names);
    }
}
