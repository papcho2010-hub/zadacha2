using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha2
{
    internal class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        public RacionalNumber(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public void Reduce()
        {
            int nod = BiggestDivider(numerator, denumerator);

            numerator /= nod;
            denumerator /= nod;
        }

        private int BiggestDivider(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        public double Value()
        {
            return (double)numerator / denumerator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denumerator}";
        }
    }
}
