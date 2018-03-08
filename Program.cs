using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateOne, dateTwo;
            DateTime dtOne, dtTwo;
            Console.WriteLine("Enter Date in this Format(YYYY-MM-DD): ");
            dateOne = Console.ReadLine();
            dtOne = Convert.ToDateTime(dateOne);

            Console.WriteLine("Enter Date in this Format(YYYY-MM-DD): ");
            dateTwo = Console.ReadLine();
            dtTwo = Convert.ToDateTime(dateTwo);

            TimeSpan span = (dtOne - dtTwo);


            Console.WriteLine("Time Difference (minutes): " + Math.Abs(span.TotalMinutes));
            Console.WriteLine("Time Difference (hours): " + Math.Abs(span.TotalHours));
            Console.WriteLine("Time Difference (days): " + Math.Abs(span.TotalDays));







        }

    }
}
