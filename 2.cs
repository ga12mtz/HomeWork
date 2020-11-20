using System;

namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                Console.Write("num1/num2 = ");
                Console.WriteLine(num1 / num2);
            }               
            else
                Console.WriteLine("Second number is invalid");
        }
    }
}
