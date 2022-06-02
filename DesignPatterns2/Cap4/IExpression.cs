using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public interface IExpression
    {
        int Avaliate();
        void Accept(IPrinterVisitor print);
    }
}
