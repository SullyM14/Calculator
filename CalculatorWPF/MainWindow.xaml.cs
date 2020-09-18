using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculator;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1; // this is double data type number called num1
        double num2; // this is double data type number called num2
        double totalNumber; // this is the double data number called totalNumber this will be used to show the total calculation
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddingNumbers(object sender, RoutedEventArgs e)
        {
            ConvertToDouble();
            totalNumber = Calculator.StaticCalculator.Add(num1, num2);
            result.Content = totalNumber;
        }

        private void ConvertToDouble()
        {
            num1 = Convert.ToDouble(numberA.Text);
            num2 = Convert.ToDouble(numberB.Text);
        }

        private void SubtractNumbers(object sender, RoutedEventArgs e)
        {
            ConvertToDouble();
            totalNumber = Calculator.StaticCalculator.Subtract(num1, num2);
            result.Content = totalNumber;
        }

        private void MultiplyNumbers(object sender, RoutedEventArgs e)
        {
            ConvertToDouble();
            totalNumber = Calculator.StaticCalculator.Multiply(num1, num2);
            result.Content = totalNumber;
        }

        private void DivideNumbers(object sender, RoutedEventArgs e)
        {
            ConvertToDouble();
            try
            {
                totalNumber = Calculator.StaticCalculator.Divide(num1, num2);
                result.Content = totalNumber;
            }
            catch(DivideByZeroException a) 
            {
                result.Content = "Can't divide by zero";
            }
        }

        private void ModulusNumbers(object sender, RoutedEventArgs e)
        {
            ConvertToDouble();
            totalNumber = Calculator.StaticCalculator.Modulus(num1, num2);
            result.Content = totalNumber;
        }
    }
}
