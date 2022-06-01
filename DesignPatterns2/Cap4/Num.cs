namespace DesignPatterns2.Cap4
{
    class Num : IExpression
    {
        private readonly int _num;

        public Num(int num)
        {
            _num = num;
        }

        public int Avaliate()
        {
            return _num;
        }
    }
}
