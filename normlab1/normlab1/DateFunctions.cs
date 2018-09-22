using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normlab1
{
    static class DateFunctions
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            //какие-то расчеты
            { return true;
            }
            else { return false;
            }
        }
    }

}
