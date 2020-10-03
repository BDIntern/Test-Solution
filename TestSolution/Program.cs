using System;

namespace TestSolution
{
    public class Program
    {
        static readonly string location;
        static readonly DateTime time;
        static void Main(string[] args)
        {
            Console.WriteLine(location ?? "Location is null.");
            Console.WriteLine(time == null ? "Time is null." : time.ToString());
            Console.ReadKey();
        }
    }
}
