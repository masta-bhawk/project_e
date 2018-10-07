using System;

namespace Project_E
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bVal = false;
            var p2 = new Problem2();
            if (p2.Evaluate() == p2.ValidatedAnswer())
                bVal = true;



        }
    }
}
