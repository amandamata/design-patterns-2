using DesignPatterns2.visitors;

namespace DesignPatterns2.interpreter
{
    public interface IExpression
    {
        int Avaliate();
        void Accept(IPrinterVisitor print);
    }
}
