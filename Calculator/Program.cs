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
            try
            {
                double answer = x / y;
                return answer;
            }
            catch(Exception e)
            {
                return 0; ;
            }
        }
        public static double Modulus(double x, double y)
        {
            double answer = x % y;
            return answer;
        }

        //public static void Calculator(string function)
        //{
        //    if (function == "Add")
        //    {
        //        Console.WriteLine("Please enter the numbers you would like to add?");
        //        string entry = Console.ReadLine();
        //        string[] values = entry.Split(',');
        //        int number1 = int.Parse(values[0]);
        //        int number2 = int.Parse(values[1]);
        //        int answer = Add(number1, number2);
        //        Console.WriteLine("The answer is " + answer);
        //    }
        //    if (function == "Subtract")
        //    {
        //        Console.WriteLine("Please enter the numbers you would like to subtract?");
        //        string entry = Console.ReadLine();
        //        string[] values = entry.Split(',');
        //        int number1 = int.Parse(values[0]);
        //        int number2 = int.Parse(values[1]);
        //        int answer = Subtract(number1, number2);
        //        Console.WriteLine("The answer is " + answer);
        //    }
        //    if (function == "Divide")
        //    {
        //        Console.WriteLine("Please enter the numbers you would like to divide?");
        //        string entry = Console.ReadLine();
        //        string[] values = entry.Split(',');
        //        int number1 = int.Parse(values[0]);
        //        int number2 = int.Parse(values[1]);
        //        int answer = Divide(number1, number2);
        //        Console.WriteLine("The answer is " + answer);
        //    }
        //    if (function == "Multiply")
        //    {
        //        Console.WriteLine("Please enter the numbers you would like to multiply?");
        //        string entry = Console.ReadLine();
        //        string[] values = entry.Split(',');
        //        int number1 = int.Parse(values[0]);
        //        int number2 = int.Parse(values[1]);
        //        int answer = Multiply(number1, number2);
        //        Console.WriteLine("The answer is " + answer);
        //    }
        //    if (function == "Modulus")
        //    {
        //        Console.WriteLine("Please enter the numbers you would like to find the Modulus for?");
        //        string entry = Console.ReadLine();
        //        string[] values = entry.Split(',');
        //        int number1 = int.Parse(values[0]);
        //        int number2 = int.Parse(values[1]);
        //        int answer = Modulus(number1, number2);
        //        Console.WriteLine("The answer is " + answer);
        //    }
        //    //else
        //    //{
        //    //    Console.WriteLine("Incorrect Function, Please try again.");
        //    //    Console.WriteLine("Please Enter the function you would like to do");
        //    //    var function1 = Console.ReadLine();
        //    //    Calculator(function1);
        //    //}
        //}

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
