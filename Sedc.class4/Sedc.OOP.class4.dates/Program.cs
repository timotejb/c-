using System;

namespace Sedc.OOP.class4.dates
{
    class Program
    {
        static void Main(string[] args)
        {          
            DateTime date = new DateTime(); //date time sekogsh go koristi lokalnoto vreme na masinata. Treba da se vnimava na vremenski zoni
            Console.WriteLine(date);

            DateTime customDate = new DateTime(2001, 06, 23);
            Console.WriteLine(customDate);

            string date1 = "12.15.2012";
            string date2 = "12/15/2012";
            string date3 = "12/15/12";
            string date4 = "dec.15.12";
            string date5 = "12-15-2012";

            DateTime convertDate = DateTime.Parse(date5);
            Console.WriteLine(convertDate);

            DateTime currentDay = DateTime.Today;
            Console.WriteLine(currentDay);

            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            DateTime adedDays = currentDateAndTime.AddDays(5);//mozhe i subtract. a mozhe i so add hours , add minutes, add years

            int year = currentDateAndTime.Year;
            int day = currentDateAndTime.Day;
            int month = currentDateAndTime.Month;

            string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            Console.WriteLine(dateFormat1);

            string dateFormat2 = currentDateAndTime.ToString("dddd,dd,MMMM yyyy");
            Console.WriteLine(dateFormat2);

            DateTime add3Days = currentDateAndTime.AddDays(3);
            Console.WriteLine(add3Days);
            DateTime addMonth = currentDateAndTime.AddMonths(1);
            Console.WriteLine(addMonth);
            DateTime addMonth3Days = currentDateAndTime.AddMonths(1).AddDays(3);
            Console.WriteLine(addMonth3Days);
            DateTime subYear2Months = currentDateAndTime.AddYears(-1).AddMonths(-2);
            Console.WriteLine(subYear2Months);
            int currentMonth = currentDateAndTime.Month;
            Console.WriteLine(currentMonth);
            int currentYear = currentDateAndTime.Year;

        }
    }
}
