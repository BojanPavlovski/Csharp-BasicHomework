using Homework_05.Models;

int[] position = { 1, 2 };

Shape shape = new Shape("Test", "Green", position);
shape.getArea();
shape.getPerimeter();
shape.Move();

Rectangle rectangle = new Rectangle("FirstRec", "Blue", position, 10, 25);
rectangle.getArea();
rectangle.getPerimeter();
rectangle.Move();

Circle circle = new Circle("FirstCircle", "Yellow", position, 55);
circle.getArea();
circle.getPerimeter();
circle.Move();
