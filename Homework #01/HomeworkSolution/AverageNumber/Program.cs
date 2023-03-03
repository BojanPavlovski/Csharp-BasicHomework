//Task 2
Console.WriteLine("Enter the first number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number");
int thirdNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the fourth number");
int fourthNum = Convert.ToInt32(Console.ReadLine());

int sum = firstNum + secondNum + thirdNum + fourthNum;
int result = sum / 4;

Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum} and {fourthNum} is: {result}");

