using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public interface ICalculator
    {
        //abstract methods
        double Sum(double x, double y);
        double Difference(double x, double y);
        double Mult(double x, double y);
        double Division(double x, double y);



    }
}
