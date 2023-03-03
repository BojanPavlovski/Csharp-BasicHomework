//Task 1

Console.WriteLine("Enter the first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the operation(+,-,*,/):");
var operation = Console.ReadLine();


if (operation == "+")
{
    int result = firstNumber + secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (operation == "-")
{
    int result = firstNumber - secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if(operation == "*")
{
    int result = firstNumber * secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if(operation == "/")
{
    int result = firstNumber / secondNumber;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("Enter valid inputs.");
}


