namespace Calculate.Calculator
{
    //分数类
    internal class Fraction
    {
        private int m_Numerator;
        private int m_Denominator;

        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
            : this()
        {
            m_Numerator = numerator;
            m_Denominator = denominator;
        }

        public int Numerator
        {
            get
            {
                return m_Numerator;
            }

            set
            {
                m_Numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return m_Denominator;
            }
            set
            {
                m_Denominator = value;
            }
        }

        public override string ToString()
        {
          
            return m_Numerator.ToString() + "/" + m_Denominator.ToString();
        }

    }
}
