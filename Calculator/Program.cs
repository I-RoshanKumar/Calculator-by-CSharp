using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string ans;
            int result;

            Console.WriteLine("Hello, welcome to the Calculator program");

            Console.WriteLine("Enter your first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which type of operator do you want to use?");
            Console.WriteLine("Please enter a for addition, s for subtraction, d for division and other key for multiplication");
            ans = Console.ReadLine();

            if (ans == "a")
            {
                result = num1 + num2;
            }
            else if (ans == "s")
            {
                if (num1 > num2)
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num2 - num1;
                }
                
            }
            else if (ans == "d")
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return;
                }
            }
            else 
            {
              result=num1 * num2;
            }
          

            Console.WriteLine($"The result is {result}");
            Console.WriteLine("Thank you for using the calculator");
            Console.ReadKey();
        }
    }
}
