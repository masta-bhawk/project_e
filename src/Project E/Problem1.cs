using System;
using System.Collections.Generic;
using System.Text;

namespace Project_E
{
    public class Problem1 : IProblem
    {
        const int MAX = 1000;

        public int Evaluate()
        {
            int sum = 0;

            for (int x = 0; x < MAX; x++)
            {
                if ((x % 3 == 0) || (x % 5 == 0))
                {
                    sum += x;
                }
            }
            return sum;
        }

        public string GetName()
        {
            return "Problem 1";
        }

        public int ValidatedAnswer()
        {
            return 233168;
        }
    }
}
