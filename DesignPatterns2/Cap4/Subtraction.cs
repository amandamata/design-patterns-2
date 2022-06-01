namespace DesignPatterns2.Cap4
{
    class Subtraction : IExpression
    {
        private readonly IExpression _firstExpression;
        private readonly IExpression _secondExpression;

        public Subtraction(IExpression firstExpression, IExpression secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Avaliate()
        {
            int firstValue = _firstExpression.Avaliate();
            int secondValue = _secondExpression.Avaliate();
            return firstValue - secondValue;
        }
    }
}
