using System;

class Program
{
    static void Main()
    {
        //String name = "John";
        //const name = "Doe"; 
        //Console.WriteLine(name);

        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        Console.WriteLine(name);


        //Console.Write("Enter your age: ");
        //int age = Console.ReadLine();// This will cause a compile-time error because Console.ReadLine() returns a string, not an int.
        Console.Write("Enter your age: ");
        String ageS = Console.ReadLine();
        int age = int.Parse(ageS); // This will convert the string input to an integer.
        Console.WriteLine(age);

        Console.Write("Enter your height in cm: ");

        double height = Convert.ToDouble(Console.ReadLine()); // This will convert the string input to a double.
        Console.WriteLine(height);

        Console.Write("Enter your salary: ");
        int salary = Convert.ToInt32(Console.ReadLine()); // This will convert the string input to an integer.


        while (salary < 0)
        {
            Console.WriteLine("Salary cannot be negative. Please enter a valid salary.");
            Console.Write("Enter your salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }


        // Even  /  Odd Checker
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");

        }

        // Table Multiplication
        Console.Write("Enter a number to see its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiplication Table of {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }


        // Leap Year Checker
        Console.Write("Enter a year to check if it's a leap year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}