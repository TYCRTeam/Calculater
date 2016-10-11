namespace JohnHuang.Calculator
{
    // 操作数
    internal class Operand : Element
    {
        private double m_Val;

        public Operand() : base(ElementType.OPERAND)
        {
        }

        public Operand(double val)
            : this()
        {
            m_Val = val;
        }

        public double Val
        {
            get
            {
                return m_Val;
            }
            set
            {
                m_Val = value;
            }
        }

    }
}
