using System;
using System.Collections.Generic;
using System.Text;

namespace Project_E
{
    public class Problem2 : IProblem
    {
        public string GetName()
        {
            return "Problem 2";
        }

        public int ValidatedAnswer()
        {
            return 4613732;
        }

        public int Evaluate()
        {
            int sum = 0;

            // Get the fibonacci numbers
            var fibs = fib();
            foreach (var fib in fibs)
            {
                // If the term is even, add it to the running sum total
                if (fib % 2 == 0)
                    sum += fib;
            }

            return sum;
            
        }

        // Get the numbers in the fibonacci sequence below value of "max"
        private IEnumerable<int> fib(int max = 4000000)
        {
            var seq = new List<int>();

            int a = 0, b = 1, c = 0;

            seq.Add(a);
            seq.Add(b);

            for (int i = 2; ; i++)
            {
                // Add the prev 2 numbers to get the current
                c = a + b;

                // Don't include this term if we are above max
                if (c > max)
                {
                    break;
                }

                // Add the current number
                seq.Add(c);

                // Move up
                a = b;
                b = c;
            }

            return seq;
        }
        
    }


}
