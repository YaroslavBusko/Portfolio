using System;
using System.Diagnostics.Eventing.Reader;   

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /* double VariableA, VariableB;
                 string action;

                  Console.WriteLine("Input variable a");
                  VariableA = double.Parse(Console.ReadLine());


                  Console.WriteLine("Input variable b");
                  VariableB = double.Parse(Console.ReadLine());

                  Console.WriteLine("Choose your action: '+', '-','*','/,'%'");
                  action = Console.ReadLine();

                 switch (action)
                 {
                     case "+":
                         Console.WriteLine(VariableA + VariableB);
                         break;
                     case "-":
                         Console.WriteLine(VariableA - VariableB);
                         break;
                     case "*":
                         Console.WriteLine(VariableA * VariableB);
                         break;
                     case "/":
                         Console.WriteLine(VariableA / VariableB);
                         if (VariableB == 0)
                             Console.WriteLine("You can't devide by 0");
                         break;
                     case "%":
                         Console.WriteLine(VariableA % VariableB);
                         break;
                     default:
                         Console.WriteLine("Incorrect symbol");
                         break;
                 }
                 Console.ReadLine(); */
                Console.Clear();

                double Number1, Number2;
                string operations;
                try
                {
                    Console.WriteLine("Input first number");
                    Number1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Input second number");
                    Number2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {   
                    Console.WriteLine("Only numbers input available");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Choose your action: '+', '-','*','/,'%'");
                operations = Console.ReadLine();

                if (operations == "+")
                    Console.WriteLine(Number1 + Number2);
                else if (operations == "-")
                    Console.WriteLine(Number1 - Number2);
                else if (operations == "*")
                    Console.WriteLine(Number1 * Number2);
                else if (operations == "/")
                    Console.WriteLine(Number1 / Number2);
                    if (Number2 == 0)
                    Console.WriteLine("You can't devide by 0");
                else if (operations == "%")
                    Console.WriteLine(Number1 % Number2);
                else
                    Console.WriteLine("Please input wright suymbol like as '+', '-','*','/,'%'");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
