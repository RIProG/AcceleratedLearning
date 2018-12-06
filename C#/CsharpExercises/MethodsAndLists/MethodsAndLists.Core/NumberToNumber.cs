using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberToNumber
    {
        public int SumNumbersTo(int input)
        {
            return input <= 0 ? throw new ArgumentException() : Enumerable.Range(1, input).Sum(); 

        }

        public int SumNumbersTo_WithoutLinq(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = 0; i <= input; i++)
            {
                sum += i; 
            }
            return sum;
        }

        public int SumNumbers(int from, int to)
        {
            int sum = 0;
            if (from > to)
            {
                throw new ArgumentException();
            }
            for (int i = from; i <= to; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int SumNumbers_Linq(int v1, int v2)
        {
            return v1 > v2 ? throw new ArgumentException() : Enumerable.Range(v1, (v2-v1+1)).Sum();
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input <= 0)
                    throw new ArgumentException();

                else if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public int SumNumbersDividedByThreeOrFive_Linq(int input)
        {
            if (input <= 0)
                throw new ArgumentException();

            return Enumerable.Range(1, input).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
