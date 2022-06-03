using DesignPatterns2.visitors;

namespace DesignPatterns2.interpreter
{
    public class Subtraction : IExpression
    {
        public IExpression FirstExpression { get; private set; }
        public IExpression SecondExpression { get; private set; }

        public Subtraction(IExpression firstExpression, IExpression secondExpression)
        {
            FirstExpression = firstExpression;
            SecondExpression = secondExpression;
        }

        public int Avaliate()
        {
            int firstValue = FirstExpression.Avaliate();
            int secondValue = SecondExpression.Avaliate();
            return firstValue - secondValue;
        }

        public void Accept(IPrinterVisitor printer)
        {
            printer.PrintSubtraction(this);
        }
    }
}
