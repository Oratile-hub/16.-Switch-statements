using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This program will provide you the day of the week
            //through a given number that coresponds to that day
            //of the week, IE: Monday => 1st day of the week

            int num;
            string result;

        label:

            Console.Write("Enter a number between 1 and 7: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    result = "Monday";
                    Console.WriteLine("{0} => {1}st day of the week", result, num);
                    break;
                case 2:
                    result = "Tuesday";
                    Console.WriteLine("{0} => {1}nd day of the week", result, num);
                    break;
                case 3:
                    result = "Wednesday";
                    Console.WriteLine("{0} => {1}rd day of the week", result, num);
                    break;
                case 4:
                    result = "Thursday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 5:
                    result = "Friday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 6:
                    result = "Saturday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 7:
                    result = "Sunday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                default:
                    Console.WriteLine("That's not a day..");
                    goto label;
            }
                    Console.ReadLine();

        }
    }
}
