using System;
using System.Collections.Generic;
using System.Text;

namespace Project_E
{
    public class Problem3 : IProblem
    {
        public int Evaluate()
        {
            //var factors = FindFactors(600851475143);
            var factors = Factor(600851475143);

            var primeFactors = FindPrimes(factors);

            return GetMax(primeFactors);
            
        }

        public int ValidatedAnswer()
        {
            return 6857;
        }

        private int GetMax(IEnumerable<long> things)
        {
            long max = 0;

            foreach (var thing in things)
            {
                if (thing > max)
                {
                    max = thing;
                }
            }

            return (int)max;
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            // You can do less work by observing that at this point, all primes 
            // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
            // The other possible remainders have been taken care of.
            long i = 6; // start from 6, since others below have been handled.
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            return true;
        }

        private IEnumerable<long> FindPrimes(IEnumerable<long> factors)
        {
            var primes = new List<long>();

            foreach(var factor in factors)
            {
                if (IsPrime(factor))
                {
                    primes.Add(factor);
                }
            }

            return primes;
        }

        private IEnumerable<long> FindFactors(long num)
        {
            var factors = new List<long>();

            for (long x=1; x<=num; x++)
            {
                if (num % x == 0)
                    factors.Add(x);
            }

            return factors;
        }


        public List<long> Factor(long number)
        {
            List<long> factors = new List<long>();
            long max = (long)Math.Sqrt(number);  //round down
            for (long factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
    }
}
