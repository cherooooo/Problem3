using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date and Time Now:" + DateTime.Now);
            Console.WriteLine("Please input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date and Time after " + number + " hours: " + DateTime.Now.AddHours(number));
        }
    }
}
