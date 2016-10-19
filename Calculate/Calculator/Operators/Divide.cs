using System;

namespace Calculate.Calculator.Operators
{
    // /
    internal class Divide : Operator, BinaryOperator
    {
        public Divide() : base(OperatorType.DIVIDE, 2)
        {
        }

        public double Operate(double num1, double num2)
        {
            if (num2 == 0d)
            {
                throw new ArithmeticException("分母不能为0！");
            }
            return num1 / num2;
        }
    }
}
