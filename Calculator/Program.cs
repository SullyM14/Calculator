using System;
using System.Linq;

namespace Calculator
{
    public class StaticCalculator
    {

        public static int DoThis(int x, string y, out bool z)
        {
            Console.WriteLine(y);
            z = (x > 10);
            return x * x;
        }

        public static (int xsquared, bool y_gt_10) DoThat(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);
            return (x * x, z);
        }
        public static double Add(double x, double y)
        {
            double answer = x + y;
            return answer;
        }
        public static double Subtract(double x, double y)
        {
            double answer = x - y;
            return answer;
        }
        public static double Multiply (double x, double y)
        {
            double answer = x * y;
            return answer;
        }
        public static double Divide(double x, double y)
        {
                if (x == 0 || y == 0)
                {
                    throw new DivideByZeroException();
                }
                double answer = x / y;
                return answer;
        }
        public static double Modulus(double x, double y)
        {
            double answer = x % y;
            return answer;
        }

        public static void Main(string[] args)
        {
            var result = DoThis(11, "numbers", out bool isLarge);
            Console.WriteLine(isLarge);
            //var myTuple = ("Suleman", "Miah", 21);
            var myNamedTuple = (Name: "Henry", Age: 21);
            Console.WriteLine(myNamedTuple);
            Console.WriteLine("Please Enter the function you would like to do");
            var function = Console.ReadLine();
            //Calculator(function);
        }
    }
}
