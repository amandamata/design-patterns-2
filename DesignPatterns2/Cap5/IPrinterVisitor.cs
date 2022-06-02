using DesignPatterns2.Cap4;

namespace DesignPatterns2.Cap5
{
    public interface IPrinterVisitor
    {
        void PrintSum(Sum sum);
        void PrintSubtraction(Subtraction subtraction);
        void PrintNumber(Num num);
    }
}
