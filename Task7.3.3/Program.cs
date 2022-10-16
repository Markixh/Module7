namespace Task7_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public abstract class ComputerPart
        {
            public abstract void Work();
        }

        class Processor : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Процессор работает");
            }
        }

        class MotherBoard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Материнская карта работает");
            }
        }

        class GraphicCard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("Видеокарта работает");
            }
        }
    }
}