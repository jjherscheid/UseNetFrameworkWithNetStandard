using System;
using System.Collections.Generic;
using System.Linq;
using UseNetFrameworkWithNetStandard.NetStandardLib;

namespace UseNetFrameworkWithNetStandard.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this .NET Core Console App");

            int[] array = new[] { 1, 4, 3, 2 };

            List<int> set = new List<int>(array);

            set = ListSorter.Sort(set).ToList();

            set.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Finished the .NET Core Console App");
            Console.ReadLine();
        }
    }
}
