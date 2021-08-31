using System;

namespace ArithmaticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            num1 = 4;
            num2 = 5;
            sum = num1 + num2;
            Console.WriteLine("The value of first variable is {0} ", num1);
            Console.WriteLine("The value of second variable is " + num2);
            Console.WriteLine("The addition of {0} and {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} is the total of {1} and {2}", sum, num1, num2);
            Console.ReadLine();
        }
    }
}
