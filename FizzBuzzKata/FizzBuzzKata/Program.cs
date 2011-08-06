using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata
{
    public class Program
    {
        public IList<String> PlayGame(int noRecords)
        {
            if (noRecords <= 0) throw new ArgumentException("noRecords must be greater than zero");

            IList<String> retVal = new List<string>();

            for (int i = 1; i <= noRecords; i++ )
            {
                if (IsDivisbleBy(3, i) && IsDivisbleBy(5, i))
                {
                    retVal.Add("FizzBuzz");
                    continue;
                }

                if (IsDivisbleBy(3, i)) {retVal.Add("Fizz");
                    continue;
                }

                if (IsDivisbleBy(5, i)) {retVal.Add("Buzz");
                    continue;
                }

                retVal.Add(i.ToString());

            }

                return retVal;
        }

        internal bool IsDivisbleBy(int divibleNo, int input)
        {
            if (input % divibleNo == 0) return true;
            return false;
        }
    }
}
