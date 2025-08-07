using System;
using dcit318_assignment2_11302021;

namespace dcit318_assignment2_11302021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine();

            // Abstract Classes and Methods
            Shape circle = new Circle(14);
            Shape rectangle = new Rectangle(10, 6);

            Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}");

            Console.WriteLine();

            // Interfaces
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}