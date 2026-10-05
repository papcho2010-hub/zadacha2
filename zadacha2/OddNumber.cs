using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha2
{
    internal class OddNumber
    {
        private int num;

        public OddNumber(int num)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return num.ToString();
        }
    }
}
