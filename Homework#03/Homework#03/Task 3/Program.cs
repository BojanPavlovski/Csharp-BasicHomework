//Task 3
Console.WriteLine("Enter a number");
string n = Console.ReadLine();

int firstInput;
bool success = int.TryParse(n, out firstInput);


int SumDigits(int firstInput)
{
    int sum = 0;
    while(firstInput > 0)
    {
        sum += firstInput % 10;
        firstInput /= 10;
    }
    Console.WriteLine($"The result is {sum}");
    return sum;
}


if (success)
{
    SumDigits(firstInput);
}
else
{
    Console.WriteLine("Invalid inputs");
}


//Bonus task
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');
string largestWord = "";

foreach (string word in words)
{
    if (word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}

Console.WriteLine($"The largest word is {largestWord}");



