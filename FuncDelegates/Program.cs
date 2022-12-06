using System;

namespace FuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var addFunc = new Func<int, int, int>(Add);
            Console.WriteLine("Sum is : " + addFunc(100,150));

            var subFunc = new Func<int, int, int>(Subtract);
            Console.WriteLine("Difference is : " + subFunc(150, 25));

            var mulFunc = new Func<int, int, int>(Multiply);
            Console.WriteLine("Product is : " + mulFunc(10, 150));

            var divFunc = new Func<double, double, double>(Divide);
            Console.WriteLine("Remainder is : " + divFunc(42.00, 4.00));

        }

        static int Add (int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber);
        }
        static int Subtract(int firstNumber, int secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber);
        }
        static double Divide(double firstNumber, double secondNumber)
        {
            return (firstNumber / secondNumber);
        }

    }
}
