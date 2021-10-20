using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> stream = new List<int>() { 1, 4, 5, 2, 3, 6, 7, 4, 5, 3, 1, 3, 4, 6 };
            foreach(var i in Task4.Sort(stream, 6, 20))
            {
                Console.WriteLine(i);
            }
        }
    }
}
