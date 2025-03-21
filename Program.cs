using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Time t1 = new Time(10, 20, 50);
        //    t1.Display();

        //    //Update values

        //    //using Property

        //    t1.Hour = 20;
        //    Console.WriteLine(t1.Hour);

        //}
        static void Main(string[] args)
        {
            ICalculator c = new MyCalculator();
            Console.WriteLine(c.Mult(2 , 4));
        }
    }
}
