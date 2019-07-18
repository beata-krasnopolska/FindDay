using System;

namespace FindDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program finds the day for a particular date");
            DateTime birthday = new DateTime(2019, 05, 17);

            Console.WriteLine("The given date is: {0}", birthday.ToString("d"));

            DateTime day = DayFinder.WeekDay(birthday);
            Console.WriteLine("The day of week for the given day is: {0}", day.DayOfWeek);

            Console.ReadKey();
        }
    }
}
