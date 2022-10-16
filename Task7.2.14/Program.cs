namespace Task7_2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            public int this[int i]
            {
                get 
                {
                    if (i >= 0 && i < array.Length)
                        return array[i];
                    else
                        return 0;
                }
            }
        }
    }
}