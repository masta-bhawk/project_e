using System;
using System.Collections.Generic;
using System.Text;

namespace Project_E
{
    public interface IProblem
    {
        string GetName();

        int Evaluate();

        int ValidatedAnswer();
    }
}
