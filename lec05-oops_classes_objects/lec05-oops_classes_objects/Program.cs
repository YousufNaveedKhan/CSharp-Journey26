using System;

// ======================
// CLASS 1 - Student
// ======================
class Student
{
    // Properties (Data)
    public string name;
    public int age;
    public double marks;

    // Method (Behavior)
    public void introduce()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Marks: {marks}");
    }

    public void showResult()
    {
        if (marks >= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
    }
}


// ======================
// CLASS 2 - Product (Real-world example)
// ======================
class Product
{
    public string name;
    public double price;
    public int quantity;

    public void showProduct()
    {
        Console.WriteLine($"Product: {name}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total: {price * quantity}");
    }
}


// ======================
// MAIN PROGRAM
// ======================
class Program
{
    static void Main()
    {
        Console.WriteLine("===== STUDENT SYSTEM =====\n");

        // Object 1
        Student s1 = new Student();
        s1.name = "Ali";
        s1.age = 20;
        s1.marks = 85;

        // Object 2
        Student s2 = new Student();
        s2.name = "Sara";
        s2.age = 22;
        s2.marks = 65;

        // Display Student 1
        Console.WriteLine("Student 1:");
        s1.introduce();
        s1.showResult();

        Console.WriteLine();

        // Display Student 2
        Console.WriteLine("Student 2:");
        s2.introduce();
        s2.showResult();

        Console.WriteLine("\n===== PRODUCT SYSTEM =====\n");

        // Product Object
        Product p1 = new Product();
        p1.name = "Laptop";
        p1.price = 50000;
        p1.quantity = 2;

        p1.showProduct();

        Console.WriteLine("\n===== USER INPUT SYSTEM =====\n");

        // Dynamic Object (User Input)
        Student s3 = new Student();

        Console.Write("Enter Name: ");
        s3.name = Console.ReadLine() ?? "";

        Console.Write("Enter Age: ");
        s3.age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        s3.marks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nStudent Details:");
        s3.introduce();
        s3.showResult();
    }
}