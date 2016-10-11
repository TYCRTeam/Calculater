using JohnHuang.Calculator;

namespace JohnHuang.Calculator.Operators
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
