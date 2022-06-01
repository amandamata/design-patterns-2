namespace DesignPatterns2.Cap4
{
    class Sum : IExpression
    {
        private readonly IExpression _firstExpression;
        private readonly IExpression _secondExpression;

        public Sum(IExpression firstExpression, IExpression secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Avaliate()
        {
            int firstValue = _firstExpression.Avaliate();
            int secondValue = _secondExpression.Avaliate();
            return firstValue + secondValue;
        }
    }
}
