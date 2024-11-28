class Program
{
    void PerformStringOperations(string str)
    {
        // Sorting
        char[] sortedArray = str.ToCharArray();
        System.Array.Sort(sortedArray);
        string sorted = new string(sortedArray);
        System.Console.WriteLine("Sorting: " + sorted);

        // Reversing
        char[] reversedArray = str.ToCharArray();
        System.Array.Reverse(reversedArray);
        string reversed = new string(reversedArray);
        System.Console.WriteLine("Reversing: " + reversed);

        // Last Index Of
        int lastIndex = str.LastIndexOf('o'); // Change 'o' as needed
        System.Console.WriteLine("Last Index Of 'o': " + lastIndex);

        // Length
        int length = str.Length;
        System.Console.WriteLine("Length: " + length);

        // Copy
        string copied = string.Copy(str);
        System.Console.WriteLine("Copy: " + copied);
    }

    static void Main()
    {
        // Create an instance of the Program class
        Program program = new Program();

        // Prompt the user for input
        System.Console.Write("Enter a string: ");
        string str = System.Console.ReadLine();

        // Perform string operations
        program.PerformStringOperations(str);
    }
}
