Queue<int> userInts = new Queue<int>();

while (true)
{
    Console.WriteLine("Enter a number!");
    string input = Console.ReadLine();
    //trying to parse the string
    int userNum;
    bool success = int.TryParse(input, out userNum);

    if (!success)
    {
        Console.WriteLine("Invalid input");
        break;
    }
    else
    {
        //if success add userNum to Queue
        userInts.Enqueue(userNum);
    }


    Console.WriteLine("Do you want to add more numbers?");
    Console.WriteLine("Enter Y for yes and N for no.");
    string userInput = Console.ReadLine().ToUpper();
    if (userInput != "Y" && userInput != "N")
    {
        Console.WriteLine("Invalid input.Try again.Enter Y/N");
        userInput = Console.ReadLine().ToUpper();
    }

    if (userInput == "N")
    {
        break;
    }
}

Console.WriteLine("The numbers are:");
//returning the values from the queue
while (userInts.Count > 0)
{
    Console.WriteLine(userInts.Dequeue());
}
