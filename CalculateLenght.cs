using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionPart
{
    public class CalculateLenght
    {
        public static double LenghtOfLine(int x1, int y1, int x2,int y2)
        {
            double result = (x2- x1)^2 + (y2-y1)^2;
            double c = Math.Sqrt(result);
            return c;
        } 
       
    }
}
