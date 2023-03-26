
namespace Homework_05.Models
{
    public class Rectangle : Shape
    {
        public int SideA;
        public int SideB;

        public Rectangle(string name, string color, int[] position, int firstSide, int secondSide) : base(name, color, position)
        {
            SideA = firstSide;
            SideB = secondSide;
        }

        public override void getArea()
        {
            Console.WriteLine($"The area is {(SideA * SideB)}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the rectangle is {(SideA + SideB) * 2}");
        }

        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Position 1: {Position[0]}, and Position 2: {Position[1]}");
        }


    }
}
