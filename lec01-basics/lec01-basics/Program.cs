String name = "Laiba";

// String interpolation
Console.WriteLine($"Hello {name}");

int age = 19;
Console.WriteLine($"Hello {name}, Age: {age}");

// String concatenation
Console.WriteLine("Hello " + name + ", Age: " + age);

bool isStudent = true;
Console.WriteLine($"Is {name} a student? {isStudent}");

double height = 5.6;
Console.WriteLine($"Hello {name}, Age: {age}, Height: {height} feet");

if (isStudent)
{
    Console.Write("I'm a student");
} else
{
    Console.Write("I'm not a student");
}

switch (age)
{
    case 18:
        Console.WriteLine("You are 18 years old.");
        break;
    case 19:
        Console.WriteLine("You are 19 years old.");
        break;
    default:
        Console.WriteLine("Your age is not 18 or 19.");
        break;
}

String[] students = [ "Anusha", "Laiba", "Anum Akram", "Umar", "Abu Hurerah", "Abdul Rehman" ];
foreach (String student in students)
{
    Console.WriteLine(student);
}

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

void greet(String name)
{
    Console.WriteLine($"Hello {name}");
}

greet("Laiba");

Console.Write("Enter your name: ");
String userName = Console.ReadLine() ?? "";
if (!string.IsNullOrEmpty(userName))
{
    Console.WriteLine($"Hello {userName}!");
}
else
{
    Console.WriteLine("Hello, stranger!");
}
