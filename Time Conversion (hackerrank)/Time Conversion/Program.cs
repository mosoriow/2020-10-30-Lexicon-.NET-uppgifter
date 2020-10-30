/*
 * Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
 * Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock
 * - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
 * 
 * Example
 * s="12:01:00PM"
 * Return '12:01:00'.
 * s="12:01:00AM"
 * Return '00:01:00'.
 * 
 * Function Description
 * Complete the timeConversion function in the editor below. It should return a new string 
 * representing the input time in 24 hour format.
 * 
 * timeConversion has the following parameter(s):
 * string s: a time in 12 hour format
 * 
 * Returns
 * string: the time in 12 hour format
 * 
 * Input Format
 *   A single string s that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or
 *   hh:mm:ssPM ).
 * 
 * Constraints
 * All input times are valid
 * 
 * Sample Input 0
 *      07:05:45PM
 * Sample Output 0
 *      19:05:45
 */

using System;

namespace Time_Conversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            string[] splitedTime = s.Split(':');

            string hour = splitedTime[0];
            string minutes = splitedTime[1];
            string seconds = splitedTime[2].Remove(2, 2);

            if (hour == "12") hour = "00";
            if (splitedTime[2].Contains("PM"))
                hour = (Int32.Parse(hour) + 12).ToString();

            return hour + ":" + minutes + ":" + seconds;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
