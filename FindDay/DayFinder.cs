using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDay
{
    public class DayFinder
    {
        public static DateTime WeekDay(DateTime sth)
        {
            DateTime newDay = new DateTime(sth.Year, sth.Month, sth.Day);
            return newDay;
        }
    }
}
