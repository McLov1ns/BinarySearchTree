namespace BinarySearchTree
{
    using System;

    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            Console.WriteLine("Enter numbers to add to the binary search tree (press Enter to stop):");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;

                int number = int.Parse(input);
                tree.Add(number);
            }

            Console.WriteLine("Enter a number to search for:");
            int searchNumber = int.Parse(Console.ReadLine());

            Node result = tree.Search(searchNumber);
            if (result != null)
                Console.WriteLine($"Node with value {searchNumber} found!");
            else
                Console.WriteLine($"Node with value {searchNumber} not found.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}