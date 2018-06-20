using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalendarClass
    {
        List<DateTime> daysMonth = new List<DateTime>();
        public CalendarClass(int year, int month)
        {
            daysMonth = Enumerable.Range(1, DateTime.DaysInMonth(year, month))  
                             .Select(day => new DateTime(year, month, day)) 
                             .ToList(); 
        }

        public List<DateTime> GetDaysForMonth()
        {
            return daysMonth;
        }

        public List<DateTime> SetDaysForMonth(int year, int month)
        {
           return daysMonth = Enumerable.Range(1, DateTime.DaysInMonth(year, month))  
                            .Select(day => new DateTime(year, month, day)) 
                            .ToList(); 
        }

    }
}
