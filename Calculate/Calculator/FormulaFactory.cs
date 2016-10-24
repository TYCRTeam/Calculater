using Calculate.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.Calculator
{
    public static class FormulaFactory
    {
         static Random ran = new Random(GetRandomSeed());//产生不重复的随机数
        
        //生成算式，complexity表示题的难易程度，范围（0、1、2）
        public static string CreateFormula(int complexity)
        {
            string formula ;

            char[] operators = { '+', '-', '*', '/' };
            int[] operands=new int[4];
            string num = null;
            
            for (int i = 0; i < operands.Length;i++ )
            {
                operands[i] = ran.Next(1, 100);//构造四个操作数
                if(i > 0) 
                { 
                   while(operands[i]==operands[i-1])
                   {
                       operands[i] = ran.Next(1,100);//确保操作数不相同
                   }
                }
            }

            if(0==complexity)
            {
                formula=CEasyFormula(operands,operators);
                num = CalculatorCore.Calculate(formula).ToString();//计算算式的结果
            }
            else if(1==complexity)
            {
                formula = CMediumFormula(operands, operators);
                num = CalculatorCore.Calculate(formula).ToString();//计算算式的结果
            }
            else
            {
                formula =CDifficultFormula(operands, operators,ref num);
            }
     
           

            return formula + "=" + num;
        }

      
        //初级难度算式构造，包含两个操作数，操作符不包括“/”，减法结果不能为负
        private static string CEasyFormula(int[] opds,char[] ops)
        {
            string formula=null;
            char op = ops[ran.Next(0, 3)];
            if (op == '-')
                CompareAndChange(ref opds[0],ref opds[1]);
            
            formula = opds[0].ToString() + op + opds[1].ToString();
            
            return formula;
        }

        
        //中级难度算式构造，包含加、减、乘的任意两个，当结果出现负号时，用括号将结果纠正
        private static string CMediumFormula(int[] opds, char[] ops) 
        {
            string formula = null;

            char op1 = ops[ran.Next(0, 3)];
            char op2=ops[ran.Next(0,3)];

            if (op1 == '-')
            {
                CompareAndChange(ref opds[0], ref opds[1]);
            }

            formula = opds[0].ToString() + op1 + opds[1].ToString()+op2+opds[2].ToString();
            
            if (CalculatorCore.Calculate(formula)<0)
            {
                if (op1 == '-')
                {
                    CompareAndChange(ref opds[0], ref opds[1]);
                    formula = "(" + opds[0].ToString() + op1 + opds[1].ToString() + ")" + op2 + opds[2].ToString();
                    if (CalculatorCore.Calculate(formula) < 0)
                    {
                        formula =  opds[2].ToString()+ op2 +"(" + opds[0].ToString() + op1 + opds[1].ToString() + ")" ;
                    }
                }
                else 
                {
                    CompareAndChange(ref opds[1], ref opds[2]);
                    formula = opds[0].ToString() + op1 +"("+ opds[1].ToString() + op2 + opds[2].ToString()+")";
                }
            }

            return formula;
        }


        //高级难度算式构造，整数与分数、分数与分数的混合运算
        private static string CDifficultFormula(int[] opds, char[] ops,ref string num) 
        {
            string formula = null;
            Fraction fraction1;
            Fraction fraction2;

            char op = ops[ran.Next(0, 3)];

            CompareAndChange(ref opds[0], ref opds[1]);
            fraction1 = new Fraction(opds[1], opds[0]);
            Simplify(ref fraction1);

            CompareAndChange(ref opds[2], ref opds[3]);
            fraction2 = new Fraction(opds[3], opds[2]);
            Simplify(ref fraction2);


            if (0 == ran.Next(1, 100) % 2)//余数为0，分数与整数运算，为1，分数与分数运算
            {
                formula = fraction1.ToString() + op + opds[2].ToString();
                num = FractionCalculator(fraction1,op,new Fraction(opds[2],1)).ToString();
                if (CalculatorCore.Calculate(formula) < 0)
                {
                    formula = opds[2].ToString() + op + fraction1.ToString();
                    num = FractionCalculator(new Fraction(opds[2], 1), op, fraction1).ToString();
                }
            }
            else 
            {
                formula = fraction1.ToString() + op + fraction2;
                num = FractionCalculator(fraction1, op, fraction2).ToString();
                if (CalculatorCore.Calculate(formula) < 0)
                {
                    formula = fraction2.ToString() + op + fraction1.ToString();
                    num = FractionCalculator(fraction2, op, fraction1).ToString();
                }
            }          

            return formula;
        }


        private static void CompareAndChange(ref int a,ref int b) 
        {
            int t;
            if(a<b)
            {
                t = a;
                a = b;
                b = t;
            }
        }

        //求最大公约数,欧几里得算法
        private static int GCD(int a,int b) 
        {
            int temp;
            if(a>=b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            while(b!=0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        } 

        //化简分数，包括约分和调整符号
        private static void Simplify(ref Fraction fra)
        {
            int gcd = GCD(fra.Numerator, fra.Denominator);
            fra.Numerator /= gcd;
            fra.Denominator /= gcd;
            //只要分母<0，就分子分母都取反符号
            if(fra.Denominator<0){
                fra.Denominator = -fra.Denominator;
                fra.Numerator = -fra.Numerator;
            }
        }

        //分数四周运算
        private static Fraction FractionCalculator(Fraction fra1,char op,Fraction fra2) {
            Fraction result = new Fraction() ;
            if ('+' == op)
            {
                result.Numerator = fra1.Numerator * fra2.Denominator + fra2.Numerator * fra1.Denominator;
                result.Denominator = fra1.Denominator * fra2.Denominator;
            }
            else if('-'==op)
            {
                result.Numerator = fra1.Numerator * fra2.Denominator- fra2.Numerator * fra1.Denominator;
                result.Denominator = fra1.Denominator * fra2.Denominator;
            }
            else if ('*' == op)
            {
                result.Numerator = fra1.Numerator * fra2.Numerator;
                result.Denominator = fra1.Denominator * fra2.Denominator;
            }
            else {
                result.Numerator = fra1.Numerator * fra2.Denominator ;
                result.Denominator = fra1.Denominator * fra2.Numerator;
            }

            Simplify(ref result);
            return result;
        }
        
        
        //确保随机数不重复
       private static int GetRandomSeed()
        { 
            byte[] bytes=new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes,0);
        }

    }

}
