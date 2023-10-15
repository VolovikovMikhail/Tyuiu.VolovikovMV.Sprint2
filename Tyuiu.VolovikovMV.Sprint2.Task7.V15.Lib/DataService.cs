using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VolovikovMV.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= Math.Sqrt(4 - (x * x))) && (y >= Math.Sqrt(1 - (x * x))))
            {
                return true;
            }
            else return false;
        }
    }
}
