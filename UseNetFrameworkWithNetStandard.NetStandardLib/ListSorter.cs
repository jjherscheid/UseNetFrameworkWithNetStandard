using System;
using System.Collections.Generic;
using System.Linq;

namespace UseNetFrameworkWithNetStandard.NetStandardLib
{
    public class ListSorter
    {
        public static IEnumerable<int> Sort(IEnumerable<int> set)
        {
            Console.WriteLine("Ordering in super handy ListSorter Class created in .NET Standard");

            return set.OrderBy(item => item);

            #region PowerCollections

            //return new Wintellect.PowerCollections.OrderedSet<int>(set);

            #endregion 
        }
    }
}
