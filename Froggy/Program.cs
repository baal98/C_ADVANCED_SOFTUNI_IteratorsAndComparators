using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake stones = new Lake(inputs);
            Console.WriteLine(String.Join(", ", stones));
        }
    }
}
