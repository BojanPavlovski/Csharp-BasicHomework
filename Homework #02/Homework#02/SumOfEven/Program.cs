//Task 1
int[] arrayOfNumbers = new int[6];
int sum = 0;


for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Enter a digit:");
    arrayOfNumbers[i] = int.Parse(Console.ReadLine());

}


foreach (int number in arrayOfNumbers)
{

    if (number % 2 == 0)
    {
        sum += number;

    }
    else if (number % 2 == 1)
    {
        continue;
    }
    else
    {
        Console.WriteLine("Invalid input");
    }


}
Console.WriteLine($"The result is {sum}");
