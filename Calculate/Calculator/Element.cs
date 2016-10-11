namespace JohnHuang.Calculator
{
    // 抽象元素
    internal abstract class Element
    {
        private ElementType m_ElementType;

        public ElementType ElementType
        {
            get
            {
                return m_ElementType;
            }
        }

        public Element(ElementType eleType)
        {
            this.m_ElementType = eleType;
        }
    }
}
