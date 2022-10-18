namespace Task7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car<ElectricEngine>();
            Console.WriteLine("Hello, World!");
        }

        class Car<T1>
        {
            public T1 Engine;
            public virtual void ChangePart<T2>(T2 newPart)
            {

            }
        }

        class ElectricEngine
        {

        }

        class GasEngine
        {

        }

        class Battery
        {

        }

        class Differential
        {

        }

        class Wheel
        {

        }
    }
}