using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04Lesson02_Homework
{
    class Calculate
    {
        public static double Add(double x, double y)
        {
            double output = x + y;

            return output;
        }

        public static double Multiply(double x,double y)
        {
            double output = x * y;

            return output;
        }

        public static double Divide(double x, double y)
        {
            try
            {
                double output = x / y;

                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
