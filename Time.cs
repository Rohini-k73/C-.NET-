using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Time
    {
        int hr, min, sec;


        public Time()
        {
            hr = min = sec = 0;
        }

        public Time(int hr, int min, int sec)
        {
            this.hr = hr;
            this.min = min;
            this.sec = sec;
        }

        public void Display()
        {
            Console.WriteLine(hr+" : " + min+ " : " + sec+" : ");
        }

        //property 

        public int Hour
        {
            get
            {
                return hr;
            }
            set
            {
                hr = value;
            }
        }
    }
}
