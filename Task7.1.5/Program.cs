using System.Drawing;

namespace Task7_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        class Plant
        {
            public int Size;
        }

        class Vegetable : Plant
        {

        }

        class Berry : Plant
        {

        }

        class Fruit : Plant
        {

        }

        class Apple : Fruit
        {

        }

        class Banana : Berry
        {

        }

        class Pear : Fruit
        {

        }

        class Potato : Vegetable
        {

        }

        class Carrot :Vegetable
        {

        }        
    }
}