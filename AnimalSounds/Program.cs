using System;

namespace MovableExample
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public class MovExample
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bicycle bicycle = new Bicycle();
            bicycle.Move();
        }
    }
}
