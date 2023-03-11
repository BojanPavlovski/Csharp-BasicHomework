//Task 2
Console.WriteLine("Write a sentence");
string sentenceInput = Console.ReadLine();


string[] splittedSentence = sentenceInput.Split(" "); 
foreach (string word in splittedSentence)
{
    Console.WriteLine(word);
}