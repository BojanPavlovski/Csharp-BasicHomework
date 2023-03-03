//Task 3
Console.WriteLine("Enter the first number:");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Before swap: {firstNum}, {secondNum}");

int temp = firstNum;
firstNum = secondNum;
secondNum = temp;

Console.WriteLine("After swap:");
Console.WriteLine("First number is " + firstNum);
Console.WriteLine("Second number is " + secondNum);



