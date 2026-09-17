using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace Day09oop
{
  class Helper2<T>
  {
    public static int SearchArray(T[] array, T value)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (EqualityComparer<T>.Default.Equals(array[i], value))
        {
          return i;
        }
      }

      return -1;



    }
    public static void ReplaceArray(
        T[] array,
        T oldValue,
        T newValue)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (EqualityComparer<T>.Default.Equals(
            array[i],
            oldValue))
        {
          array[i] = newValue;
        }
      }
    }
   








  }
}
