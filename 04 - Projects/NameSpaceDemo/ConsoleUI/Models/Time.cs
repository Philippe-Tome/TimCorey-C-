using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    class Time
    {
        public static DateTime GetTimeStamp()
        {
            DateTime timeStamp = DateTime.Now;
            //return DateTime.Now.Hour();
            return timeStamp;
            //return Time.GetTimeStamp();
        }

    }
}
