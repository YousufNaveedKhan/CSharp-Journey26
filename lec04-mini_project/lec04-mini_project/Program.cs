using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine() ?? "";

        int[] marks = new int[3];

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Enter marks {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        foreach (int mark in marks)
        {
            sum += mark;
        }

        double average = (double)sum / marks.Length;

        string grade;

        if (average >= 80)
        {
            grade = "A";
        }
        else if (average >= 60)
        {
            grade = "B";
        }
        else if (average >= 50)
        {
            grade = "C";
        }
        else
        {
            grade = "Fail";
        }

        Console.WriteLine($"\nStudent: {name}");
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Grade: {grade}");
    }
}