namespace Task7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car<ElectricEngine>();
            Console.WriteLine("Hello, World!");
        }

        abstract class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;
            public virtual void ChangePart<TPart>(TPart newPart) where TPart : Part { }
        }

        abstract class Engine { }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        abstract class Part { }

        class Battery : Part { }

        class Differential : Part { }

        class Wheel : Part { }

        class ElectricCar : Car<ElectricEngine> 
        {
            public override void ChangePart<TPart>(TPart newPart)
            {
                base.ChangePart(newPart);
            }
        }
        class GasCar : Car<GasEngine> 
        {
            public override void ChangePart<TPart>(TPart newPart)
            {
                base.ChangePart(newPart);
            }
        }
    }
}