namespace Prac
{
    internal class Program
    {
        public delegate int Operation(int a, int b);

        public class Calculator
        {
            public static int Addition(int a, int b)
            {
                return a + b;
            }

            public  int Subtraction(int a, int b)
            {
                return a - b;
            }
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Operation addition = new Operation(Calculator.Addition);
            int result = addition(20, 5);
            Console.WriteLine($"Addition result: {result}");

            Operation addition2 = new Operation(calc.Subtraction);
            int respone = addition2(10,8);
            Console.WriteLine($"Subtraction result: {respone}");
        }
    }
}
