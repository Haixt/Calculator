using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            String operation;
            String choice;
            double result = 0;

            do
            {
                Console.WriteLine(" 1 Addition");
                Console.WriteLine(" 2 Subtraction");
                Console.WriteLine(" 3 Multiplication");
                Console.WriteLine(" 4 Division");

                Console.WriteLine("Enter desired operation: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Please enter first value: ");
                        firstNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter second value: ");
                        secondNum = Convert.ToInt32(Console.ReadLine());
                        result = firstNum + secondNum;
                        break;
                    case "2":
                        Console.WriteLine("Please enter first value: ");
                        firstNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter second value: ");
                        secondNum = Convert.ToInt32(Console.ReadLine());
                        result = firstNum - secondNum;
                        break;
                    case "3":
                        Console.WriteLine("Please enter first value: ");
                        firstNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter second value: ");
                        secondNum = Convert.ToDouble(Console.ReadLine());
                        result = firstNum * secondNum;
                        break;
                    case "4":
                        Console.WriteLine("Please enter first value: ");
                        firstNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter second value: ");
                        secondNum = Convert.ToDouble(Console.ReadLine());
                        result = firstNum / secondNum;
                        break;
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;


                }
                Console.WriteLine("The result is {0}", result);
                Console.ReadKey();

                Console.WriteLine("Do you want to try again? y or n : ");
                choice = Console.ReadLine();
                choice.ToLower();

            } while (choice == "y");
        }
            
            
    }
}
