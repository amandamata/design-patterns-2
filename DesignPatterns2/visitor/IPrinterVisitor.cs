using DesignPatterns2.interpreter;

namespace DesignPatterns2.visitors
{
    public interface IPrinterVisitor
    {
        void PrintSum(Sum sum);
        void PrintSubtraction(Subtraction subtraction);
        void PrintNumber(Num num);
    }
}
