using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x == 0)
            {
                int num1 = int.Parse(Console.ReadLine());
                string operation = Console.ReadLine();
                int num2 = int.Parse(Console.ReadLine());
                if (operation == "+")
                {
                    int answer = num1 + num2;
                    Console.WriteLine("Ans: " + answer);
                }
                else if (operation == "-")
                {
                    int answer = num1 - num2;
                    Console.WriteLine("Ans: " + answer);
                }
                else if (operation == "*")
                {
                    int answer = num1 * num2;
                    Console.WriteLine("Ans: " + answer);
                }
                else if (operation == "/")
                {
                    if (num2 != 0)
                    {
                        int answer = num1 / num2;
                        Console.WriteLine("Ans: " + answer);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                }
            }
        }
    }
}
