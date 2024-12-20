using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Extensions
{
public static class EnumerableExtensions
    {
        public static T GetRandom<T>(this IList<T> list)
        {
            Random random = new Random();
            return list[random.Next(list.Count)];
        }
    }
}

