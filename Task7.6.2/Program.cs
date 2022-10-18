namespace Task7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car<ElectricEngine>();
            Console.WriteLine("Hello, World!");
        }

        class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;
            public virtual void ChangePart<TPart>(TPart newPart) where TPart : Part { }
        }

        abstract class Engine { }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        class Part { }

        class Battery : Part { }

        class Differential : Part { }

        class Wheel : Part { }
    }
}