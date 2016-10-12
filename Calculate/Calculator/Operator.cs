namespace Calculate.Calculator
{
    // 抽象操作符
    internal abstract class Operator : Element
    {
        private int m_Priority;
        private OperatorType m_OperatorType;

        public Operator(OperatorType operatorType, int priority) : base(ElementType.OPERATOR)
        {
            this.m_OperatorType = operatorType;
            this.m_Priority = priority;
        }

        public int Priority
        {
            get
            {
                return m_Priority;
            }
        }

        public OperatorType OperatorType
        {
            get
            {
                return m_OperatorType;
            }
        }
    }
}
