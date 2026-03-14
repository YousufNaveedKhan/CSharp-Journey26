using System;

class Program
{
    static void Main()
    {
        string[] names = { "Anum", "Anusha", "Laiba", "Abu Hurerah", "Umar", "Abdul Rehman" };

        // Using foreach to iterate over the array
        Console.WriteLine("Names in the array:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        void PrintNames(string[] arr)
        {
            Console.WriteLine("\nNames in the array (using method):");
            foreach (string name in arr)
            {
                Console.WriteLine(name);
            }
        }

        // Calling the method to print names

        Console.WriteLine(names.Length);
        PrintNames(names);

        int add(int a, int b)
        {
            return a + b;
        }

        int result = add(5, 10);
        Console.WriteLine($"\nThe sum of 5 and 10 is: {result}");

        for (int i = 0; i <= 5; i++)
        {
            Console.Write(i);
            for (int a = 1; a <= 3; a++)
            {
                Console.Write(a);

            }
            Console.Write("\n");
        }
    }
}