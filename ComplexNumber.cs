using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class ComplexNumber
  {
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
      Real = real;
      Imaginary = imaginary;
    }

    public static ComplexNumber operator *(
        ComplexNumber first,
        ComplexNumber second)
    {
      double real =
          (first.Real * second.Real) -
          (first.Imaginary * second.Imaginary);

      double imaginary =
          (first.Real * second.Imaginary) +
          (first.Imaginary * second.Real);

      return new ComplexNumber(real, imaginary);
    }

    public override string ToString()
    {
      return $"{Real} + {Imaginary}i";
    }

  }

}

