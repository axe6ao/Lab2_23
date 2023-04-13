using System;
using System.Collections.Generic;

namespace DelegateLambda
{
    delegate int StringLength(string str);

    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "Hello", "world", "from", "C#" };

            StringLength length = s => s.Length;

            foreach (var str in strings)
            {
                Console.WriteLine("{0} has {1} characters", str, length(str));
            }
        }
    }
}
