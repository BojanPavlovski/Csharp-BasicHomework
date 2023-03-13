using Task_2;

Console.WriteLine("Enter the name of the dog.");
string dogName = Console.ReadLine();

Console.WriteLine("Enter the breed of the dog.");
string dogBreed = Console.ReadLine();

Console.WriteLine("Enter the color of the dog.");
string dogColor = Console.ReadLine();

Console.WriteLine("Enter a number from 1 to 3 to call a method.");
string methodNumber = Console.ReadLine();

Dog dog = new Dog(dogName, dogBreed, dogColor);

if(methodNumber == "1")
{
   string eatMethod = dog.EatMethod();
    Console.WriteLine(eatMethod);
}
else if(methodNumber == "2")
{
   string playMethod = dog.PlayMethod();
    Console.WriteLine(playMethod);
}
else if(methodNumber == "3")
{
   string chaseTailMethod = dog.ChaseTailMethod();
    Console.WriteLine(chaseTailMethod);
}
else
{
    Console.WriteLine("Invalid number.");
}



