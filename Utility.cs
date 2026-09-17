using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Utility
  {
    public static double RectanglePerimeter(double length, double width)
    {
      return 2 * (length + width);
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
      return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
      return (fahrenheit - 32) * 5 / 9;
    }






  }
}
