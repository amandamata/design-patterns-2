using DesignPatterns2.visitors;

namespace DesignPatterns2.interpreter
{
    public class Sum : IExpression
    {
        public IExpression FirstExpression { get; private set; }
        public IExpression SecondExpression { get; private set; }

        public Sum(IExpression firstExpression, IExpression secondExpression)
        {
            FirstExpression = firstExpression;
            SecondExpression = secondExpression;
        }

        public int Avaliate()
        {
            int firstValue = FirstExpression.Avaliate();
            int secondValue = SecondExpression.Avaliate();
            return firstValue + secondValue;
        }

        public void Accept(IPrinterVisitor printer)
        {
            printer.PrintSum(this);
        }
    }
}
