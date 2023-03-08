//Task 2
string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Bojan", "Stojan", "Marko", "Sharko", "Maja" };

Console.WriteLine("Enter 1 or 2");
string input = Console.ReadLine();

if (input == "1")
{
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (input == "2")
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Enter a valid input");
}

