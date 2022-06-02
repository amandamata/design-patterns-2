using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
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
