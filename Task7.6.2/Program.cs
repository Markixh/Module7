namespace Task7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car<ElectricEngine>();
            Console.WriteLine("Hello, World!");
        }

        class Car<T>
        {
            public T Engine;
        }

        class ElectricEngine
        {

        }

        class GasEngine
        {

        }
    }
}