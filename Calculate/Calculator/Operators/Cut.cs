namespace Calculate.Calculator.Operators
{
    // -
    internal class Cut : Operator, BinaryOperator
    {
        public Cut() : base(OperatorType.CUT, 1)
        {
        }

        public double Operate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
