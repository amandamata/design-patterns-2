using DesignPatterns2.visitors;

namespace DesignPatterns2.interpreter
{
    public class Num : IExpression
    {
        public int Value { get; private set; }

        public Num(int num)
        {
            Value = num;
        }

        public int Avaliate()
        {
            return Value;
        }

        public void Accept(IPrinterVisitor printer)
        {
            printer.PrintNumber(this);
        }
    }
}
