using System;

namespace Delegateexample
{

    public delegate double Nums(double x, double y);


    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }

            return x / y;
        }
    }


    public class AdvancedCalculator
    {
        public static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }

    public class DelegateExampleprogram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter First Number: ");
            double f = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double s = double.Parse(Console.ReadLine());



            Nums num = null;

            switch (choice)
            {
                case 1:
                    num = Calculator.Add;
                    break;

                case 2:
                    num = Calculator.Subtract;
                    break;

                case 3:
                    num = Calculator.Multiply;
                    break;

                case 4:
                    num = Calculator.Divide;
                    break;

                case 5:
                    num = AdvancedCalculator.Power;
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            double result = num(f, s);


            Console.WriteLine("Result = " + result);
        }
    }
}
