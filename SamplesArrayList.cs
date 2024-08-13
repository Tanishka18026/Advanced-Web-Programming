using System;
using System.Collections;

class SampleArrayList
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Find index of a value");
            Console.WriteLine("3. Check if array contains any elements");
            Console.WriteLine("4. Count of elements");
            Console.WriteLine("5. Reverse the array");
            Console.WriteLine("6. Sort the array");
            Console.WriteLine("7. List the items in the array");
            Console.WriteLine("8. Remove the last item");
            Console.WriteLine("9. Remove item at a specific index");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the item to add: ");
                    string itemToAdd = Console.ReadLine();
                    arrayList.Add(itemToAdd);
                    Console.WriteLine("Added: "+itemToAdd);
                    break;

                case 2:
                    Console.Write("Enter the value to find its index: ");
                    string valueToFind = Console.ReadLine();
                    int index = arrayList.IndexOf(valueToFind);
                    if (index >= 0)
                    {
                        Console.WriteLine("Index of " +valueToFind+ " is " +index);
                    }
                    else
                    {
                        Console.WriteLine(valueToFind+  " not found in the list.");
                    }
                    break;

                case 3:
                    if (arrayList.Count > 0)
                    {
                        Console.WriteLine("The array contains elements.");
                    }
                    else
                    {
                        Console.WriteLine("The array is empty.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Count of elements: " +arrayList.Count);
                    break;

                case 5:
                    arrayList.Reverse();
                    Console.WriteLine("The array has been reversed.");
                    break;

                case 6:
                    arrayList.Sort();
                    Console.WriteLine("The array has been sorted.");
                    break;

                case 7:
                    Console.WriteLine("Items in the array:");
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 8:
                    if (arrayList.Count > 0)
                    {
                        Console.WriteLine("Removed last item: "+arrayList[arrayList.Count - 1]);
                        arrayList.RemoveAt(arrayList.Count - 1);
                    }
                    else
                    {
                        Console.WriteLine("The array is empty, nothing to remove.");
                    }
                    break;

                case 9:
                    Console.Write("Enter the index to remove item from: ");
                    int indexToRemove = int.Parse(Console.ReadLine());
                    if (indexToRemove >= 0 && indexToRemove < arrayList.Count)
                    {
                        Console.WriteLine("Removed: " +arrayList[indexToRemove]+ " from index " +indexToRemove);
                        arrayList.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case 0:
                    continueProgram = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}