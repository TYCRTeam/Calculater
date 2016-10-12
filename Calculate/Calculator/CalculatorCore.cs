using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Calculate.Calculator.Operators;

namespace Calculate.Calculator
{
    // 公式计算帮助类
    public static class CalculatorCore
    {
        private const string NUM_PATTERN = "[0-9\\.]";

        public static double? Calculate(string formula)
        {
            List<Element> elements = ParseFormula(formula);
            double? result = null;
            if (CheckFormula(elements))
            {
                result = Calculate(elements);
            }
            return result;
        }

        // 将字符串解释为公式元素列表
        private static List<Element> ParseFormula(string formula)
        {
            List<Element> elements = new List<Element>();
            int formulaLength = formula.Length;
            bool isAssemblingOperand = false;// 标记是否正在组装操作数
            string assemblingOperand = string.Empty;// 保存正在组装的操作数
            for (int i = 0; i < formulaLength; i++)
            {

                if (Regex.IsMatch(Convert.ToString(formula[i]), NUM_PATTERN)
                    && !isAssemblingOperand)
                {
                    isAssemblingOperand = true;

                    // 若前一个操作符为),则先填充乘号
                    if (elements.Count != 0
                        && elements[elements.Count - 1].ElementType == ElementType.OPERATOR
                        && (elements[elements.Count - 1] as Operator).OperatorType == OperatorType.R_BRACKET)
                    {
                        elements.Add(new Mutiply());
                    }

                    elements.Add(new Operand());

                    // 用0.替换.添加到正在组装的操作数变量中
                    if (string.Equals(Convert.ToString(formula[i]), "."))
                    {
                        assemblingOperand += "0.";
                    }
                    else
                    {
                        assemblingOperand += formula[i];
                    }
                }
                else if (Regex.IsMatch(Convert.ToString(formula[i]), NUM_PATTERN)
                    && isAssemblingOperand)
                {

                    // 若字符为.且正在组装的操作数已存在.，则表示到达下一个小数操作数，而新旧两操作数将作乘操作
                    if (string.Equals(Convert.ToString(formula[i]), ".")
                        && assemblingOperand.IndexOf('.') > -1)
                    {
                        (elements[elements.Count - 1] as Operand).Val = Convert.ToDouble(assemblingOperand);
                        assemblingOperand = string.Empty;
                        elements.Add(new Mutiply());
                        elements.Add(new Operand());
                        assemblingOperand += "0.";
                    }
                    else
                    {
                        assemblingOperand += formula[i];
                    }
                }
                else if (!Regex.IsMatch(Convert.ToString(formula[i]), NUM_PATTERN)
                    && isAssemblingOperand)
                {
                    (elements[elements.Count - 1] as Operand).Val = Convert.ToDouble(assemblingOperand);
                    isAssemblingOperand = false;
                    assemblingOperand = string.Empty;

                    AddOperator(elements, formula[i]);
                }
                else 
                {
                    AddOperator(elements, formula[i]);
                }
            }

            if (isAssemblingOperand)
            {
                (elements[elements.Count - 1] as Operand).Val = Convert.ToDouble(assemblingOperand);
            }

            return elements;
        }

        // 计算公式
        private static double? Calculate(List<Element> formulaElements)
        {
            double? result = null;
            Stack<Operator> operators = new Stack<Operator>();
            Stack<Operand> operands = new Stack<Operand>();
            for (int i = 0; i < formulaElements.Count; i++)
            {
                if (formulaElements[i].ElementType == ElementType.OPERATOR)
                {
                    if ((formulaElements[i] as Operator).OperatorType == OperatorType.R_BRACKET
                        && operators.Peek().OperatorType == OperatorType.L_BRACKET)
                    {
                        operators.Pop();
                        Calculate(operands, operators, formulaElements, i);
                    }
                    else
                    {
                        operators.Push((formulaElements[i] as Operator));
                    }
                    
                }
                else if (formulaElements[i].ElementType == ElementType.OPERAND)
                {
                    operands.Push((formulaElements[i] as Operand));
                    Calculate(operands, operators, formulaElements, i);
                }
            }

            result = operands.Pop().Val;

            return result;
        }

        // 计算两个数的值
        private static void Calculate(Stack<Operand> operands, Stack<Operator> operators, List<Element> formulaElements, int i)
        {
            bool hasPriority = false;
            while (operands.Count >= 2
                && !hasPriority)
            {
                Operator curOperator = operators.Pop();
                // 预览下一个操作符的优先级
                Operator nextOperator = null;
                if (i + 1 < formulaElements.Count)
                {
                    nextOperator = (formulaElements[i + 1] as Operator);
                }
                if (nextOperator != null
                    && nextOperator.Priority > curOperator.Priority)
                {
                    operators.Push(curOperator);
                    hasPriority = true;
                }
                else
                {
                    CalculateMgr(curOperator, operators, operands, ref hasPriority);
                }
            }
        }

        // 将字符串中的操作符转换为公式元素
        private static void AddOperator(List<Element> elements, char oper)
        {
            if (oper == '(')
            {
                if (elements.Count != 0
                    && (elements[elements.Count - 1].ElementType == ElementType.OPERAND
                    || (elements[elements.Count - 1].ElementType == ElementType.OPERATOR
                    && (elements[elements.Count - 1] as Operator).OperatorType == OperatorType.R_BRACKET)))
                {
                    elements.Add(new Mutiply());
                }

                elements.Add(new LBracket());
            }
            else if (oper == ')')
            {
                elements.Add(new RBracket());
            }
            else if (oper == '+')
            {
                elements.Add(new Add());
            }
            else if (oper == '-')
            {
                elements.Add(new Cut());
            }
            else if (oper == '*')
            {
                elements.Add(new Mutiply());
            }
            else if (oper == '/')
            {
                elements.Add(new Divide());
            }
            else if (oper == '%')
            {
                elements.Add(new Divide());
                elements.Add(new Operand() { Val = 100 });
            }
        }

        // 检查输入的公式字符串是否合法
        private static bool CheckFormula(List<Element> elements)
        {
            bool isLegal = true;
            int length = elements.Count - 1;
            for (int i = 0; i <= length; i++)
            {
                if (i < length
                    && elements[i].ElementType == ElementType.OPERATOR
                    && elements[i + 1].ElementType == ElementType.OPERATOR)
                {
                    Operator curOper =  elements[i] as Operator;
                    Operator nextOper =  elements[i + 1] as Operator;
                    if ((curOper.OperatorType == OperatorType.ADD
                        || curOper.OperatorType == OperatorType.CUT
                        || curOper.OperatorType == OperatorType.DIVIDE
                        || curOper.OperatorType == OperatorType.MUTIPLY
                        || curOper.OperatorType == OperatorType.L_BRACKET)
                        && (nextOper.OperatorType == OperatorType.ADD
                        || nextOper.OperatorType == OperatorType.CUT
                        || nextOper.OperatorType == OperatorType.DIVIDE
                        || nextOper.OperatorType == OperatorType.MUTIPLY
                        || nextOper.OperatorType == OperatorType.R_BRACKET))
                    {
                        isLegal = false;
                        break;
                    }
                }
            }

            return isLegal;
        }

        // 计算两个数的值的具体运算
        private static void CalculateMgr(Operator curOperator, Stack<Operator> operators, Stack<Operand> operands,ref bool hasPriority)
        {
            double rightOperand;
            double leftOperand;
            double tmp;

            switch (curOperator.OperatorType)
            {
                case OperatorType.L_BRACKET:
                    operators.Push(curOperator);
                    hasPriority = true;
                    break;
                case OperatorType.R_BRACKET:
                    operators.Pop();
                    break;
                default:
                    // 四则运算
                    if (curOperator is BinaryOperator)
                    {
                        rightOperand = Convert.ToDouble(operands.Pop().Val);
                        leftOperand = Convert.ToDouble(operands.Pop().Val);
                        tmp = ((BinaryOperator)curOperator).Operate(leftOperand,rightOperand);
                        operands.Push(new Operand(){ Val = tmp });
                    }
                    break;
            }
        }
    }
}
