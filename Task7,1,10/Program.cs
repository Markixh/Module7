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

            public virtual int Counter
            {
                get;
                set;
            }

            public BaseClass(string name)
            {
                Name = name;
            }

            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public override int Counter 
            {
                get => base.Counter;
                set
                {
                    if (value > 0)
                        base.Counter = value;
                }
            }

            DerivedClass(string name, string description) : base(name)
            {
                Description = description;
            }

            DerivedClass(string name, string description, int counter) : base(name)
            {
                Description = description;
                Counter = counter;
            }

            public override void Display()
            {
                Console.WriteLine("Метод класса DerivedClass");
            }
        }
    }
}