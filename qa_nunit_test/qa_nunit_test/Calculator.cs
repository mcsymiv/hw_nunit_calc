using qa_nunit_test;
using System;
using System.Linq;

namespace qa_auto_unit_test
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Menu menu = new Menu();

            double firstNum = menu.AskFirstOperand("first");
            string oper = menu.AskOperation();
            double secondNum = menu.AskFirstOperand("second");
            double result = 0;

            switch (oper)
            {
                case "+":
                    result = calc.Addition(firstNum, secondNum);
                    break;
                case "-":
                    result = calc.Subtract(firstNum, secondNum);
                    break;
                case "*":
                    result = calc.Multiply(firstNum, secondNum);
                    break;
                case "/":
                    try
                    {
                        result = calc.Divide(firstNum, secondNum);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Divide {firstNum} by zero");
                    }
                    break;

            }
            menu.PrintResult(firstNum, oper, secondNum, result);
            Console.ReadKey();
        }
    }
}


