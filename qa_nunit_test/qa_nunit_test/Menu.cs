using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_nunit_test
{
    public class Menu
    {
        public double AskFirstOperand(string num)
        {
            double operand = 0;
            do
            {
                Console.Write($"Enter {num} number:\t");
            } while (!double.TryParse(Console.ReadLine(), out operand));
            return operand;
        }
        public string AskOperation()
        {
            string oper = "";
            bool isOper = false;
            string[] operations = new string[] { "+", "-", "*", "/", "%", "^" };
            do
            {
                AskInput();
                oper = Console.ReadLine();
                for (int j = 0; j < operations.Length; j++)
                {
                    if (oper == operations[j])
                    {
                        oper = operations[j];
                        isOper = true;
                    }
                }
            } while (!isOper);
            return oper;
        }
        public void AskInput()
        {
            Console.WriteLine("Operations are: '+', '-', '*', '/', '%', '^'");
            Console.Write("Enter calculation:\t");
        }
        public void PrintResult(double firstNum, string oper, double secondNum, double result)
        {
            Console.WriteLine($"{firstNum} {oper} {secondNum} = {result}");
        }
    }
}
