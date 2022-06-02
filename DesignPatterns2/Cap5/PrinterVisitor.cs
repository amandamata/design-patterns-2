using DesignPatterns2.Cap4;
using System;

namespace DesignPatterns2.Cap5
{
    public class PrinterVisitor : IPrinterVisitor
    {
        public void PrintSum(Sum sum)
        {
            Console.Write("(");
            sum.FirstExpression.Accept(this);
            Console.Write("+");
            sum.SecondExpression.Accept(this);
            Console.Write(")");
        }

        public void PrintSubtraction(Subtraction subtraction)
        {
            Console.Write("(");
            subtraction.FirstExpression.Accept(this);
            Console.Write("+");
            subtraction.SecondExpression.Accept(this);
            Console.Write(")");
        }

        public void PrintNumber(Num num)
        {
            Console.Write(num.Value);
        }
    }
}
