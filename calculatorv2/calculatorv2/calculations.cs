using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorv2
{
    class calculations
    {
        public string add(double s1,double s2)
        {
            return (s1 + s2).ToString();
        }

        public string sub(double s1, double s2)
        {
            return (s1 - s2).ToString();
        }

        public string mul(double s1, double s2)
        {
            return (s1 * s2).ToString();
        }

        public string div(double s1, double s2)
        {
            return (s1 / s2).ToString();
        }
    }
}
