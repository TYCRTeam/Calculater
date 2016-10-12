using Calculate.Calculator;

namespace Calculate.Calculator.Operators
{
    // +
    internal class Add : Operator, BinaryOperator
    {
        public Add() : base(OperatorType.ADD, 1)
        {
        }

        public double Operate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
