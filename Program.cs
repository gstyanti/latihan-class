using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        public void Run ()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time time1 = new Time(currentTime);
            time1.DisplayCurrentTime();
            Time time2 = new Time(2003, 2, 1, 09, 23, 30);
            time2.DisplayCurrentTime();
        }

        
    }
}
