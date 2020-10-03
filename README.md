# Test Question #

```

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

```


---
### What will be the out put of ```Console.WriteLine(location == null ? "Location is null." : location);``` statement? ###
> This statement will print __Location is null.__


---
### What will be the out put of ```Console.WriteLine(time == null ? "Time is null." : time.ToString());``` statement? ###
> This statement will print __1/1/0001 12:00:00 AM__