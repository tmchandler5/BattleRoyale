using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Math
{
    public class MathStuff
    {
        private float mavisTailLength;

        public MathStuff(int input)
        {
            this.mavisTailLength = input;
        }

        public int addToMavisTailLength(int input)
        {
            return input + (int)mavisTailLength;
        }

        static public int product1(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public MathStuff()
        {
            this.mavisTailLength = 8;
        }
    }
}
