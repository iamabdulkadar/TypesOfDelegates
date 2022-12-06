using System;

namespace ActionDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var addAction = new Action<int, int>(Add);
            var subAction = new Action<int, int>(Subtract);
            var mulAction = new Action<int, int>(Multiply);
            var divAction = new Action<double, double>(Divide);
            addAction(200, 120);
            subAction(350, 170);
            mulAction(16, 8);
            divAction(414.00, 25.00);

        }
        static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum is : " + (firstNumber + secondNumber));
        }
        static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Difference is : " + (firstNumber - secondNumber));
        }
        static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Product is : " + (firstNumber * secondNumber));
        }
        static void Divide(double firstNumber, double secondNumber)
        {
            Console.WriteLine("Remainder is : " + (firstNumber / secondNumber));
        }
    }
}
