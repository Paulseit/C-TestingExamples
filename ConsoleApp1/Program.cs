namespace ConsoleApp1
{
    public class MathHelper
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var math = new MathHelper();
            Console.WriteLine("2 + 3 = " + math.Add(2, 3));
            Console.WriteLine("4 * 5 = " + math.Multiply(4, 5));
        }
    }
}
