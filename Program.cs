using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Exercise: Month Converter
            Console.WriteLine("Give the numeric value for the month you were born");
            var month = Convert.ToInt32 (Console.ReadLine());
            DateTimeFormatInfo dateTimeInfo = new DateTimeFormatInfo();
            Console.WriteLine(dateTimeInfo.GetMonthName(month));
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            
        }
    }
}     