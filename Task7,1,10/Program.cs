namespace Task7_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class BaseClass
        {
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;

            DerivedClass(string name, string description) : base(name)
            {
                Description = description;
            }

            DerivedClass(string name, string description, int counter) : base(name)
            {
                Description = description;
                Counter = counter;
            }
        }
    }
}