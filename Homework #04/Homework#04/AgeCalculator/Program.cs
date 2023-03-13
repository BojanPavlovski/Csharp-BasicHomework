Console.WriteLine("Enter your birthday(month/day/year)");
string userInput = Console.ReadLine();
DateTime parsedDate = DateTime.Parse(userInput);



int AgeCalculator(DateTime birthdate)
{
    DateTime today = DateTime.Today;
    int age =  today.Year - birthdate.Year;
    
    if (birthdate > today)
    {
        Console.WriteLine("Invalid birthdate");
    }
    else if(birthdate < today)
    {
        Console.WriteLine("I am {0} years old", age);
    }
    else if(birthdate == today)
    {
        Console.WriteLine("Happy birthday");
    }
    
    
    return age;
}

int myAge = AgeCalculator(parsedDate);


