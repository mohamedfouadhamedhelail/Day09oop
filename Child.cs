using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Child:Person
  {
    public sealed override decimal Salary { get; set; }

    public void DisplaySalary()
    {
      Console.WriteLine($"Salary: {Salary}");
    }


  }
}
