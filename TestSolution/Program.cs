using System;

namespace TestSolution
{
    class Program
    {
        static String location;
        static DateTime time;
        static void Main(string[] args)
        {
            Console.WriteLine(location == null ? "Location is null." : location);
            Console.WriteLine(time == null ? "Time is null." : time.ToString());
            Console.ReadKey();
        }
    }
}
