using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class MyCalculator : ICalculator
    {
        double ICalculator.Difference(double x, double y)
        {
            return x - y;
        }

        double ICalculator.Division(double x, double y)
        {
            return x / y;
        }

        double ICalculator.Mult(double x, double y)
        {
            return x * y;
        }

        double ICalculator.Sum(double x, double y)
        {
            return x + y;
        }
    }
}
