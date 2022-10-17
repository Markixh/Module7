namespace Task7_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
        }

        public class Helper
        {
            public static void Swap(ref int x, ref int y)
            {
                var temp = x;
                x = y;
                y = temp;
            }
        }
    }
}