using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha2
{
    internal class EvenNumber
    {
        private int num;

        public EvenNumber(int num)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return num.ToString();
        }
    }
}
