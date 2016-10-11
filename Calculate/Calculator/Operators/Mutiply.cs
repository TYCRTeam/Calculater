namespace JohnHuang.Calculator.Operators
{
    // *
    internal class Mutiply : Operator, BinaryOperator
    {
        public Mutiply() : base(OperatorType.MUTIPLY, 2)
        {
        }

        public double Operate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
