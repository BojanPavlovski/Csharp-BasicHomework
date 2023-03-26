

namespace Homework_05.Models
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
            {
            _radius = radius;
            }
        public override void getArea()
        {
            Console.WriteLine($"The area of the circle is: {Math.PI * _radius * _radius}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the circle is: {(Math.PI * _radius * 2)}");
        }

        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Position 1: {Position[0]}, and Position 2: {Position[1]}");
        }
    }
}
