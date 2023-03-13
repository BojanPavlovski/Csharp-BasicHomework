



namespace Task_2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog()
        {

        }

        public Dog(string name, string breed, string color)
        {
            //checking if name is null or empty
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name value.");
            }
            else
            {
                Name = name;
            }
            //checking if breed is null or empty
            if(string.IsNullOrEmpty(breed))
            {
                Console.WriteLine("Invalid breed value.");
            }
            else
            {
                Breed = breed;
            }
            //checking if color is null or empty
            if(string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid color value.");
            }
            else
            {
                Color = color;
            }
            
           
        }
        public string EatMethod()
        {
            return $"The dog is now eating.";
        }

        public string PlayMethod()
        {
            return $"The dog is playing now.";
        }

        public string ChaseTailMethod()
        {
            return $"The dog is now chasing it's tail.";
        }
    }
}
