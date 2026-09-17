using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Helper
  {
    public static T Max<T>(T first, T second)
        where T : IComparable<T>
    {
      return first.CompareTo(second) > 0
          ? first
          : second;
    }




  }
}
