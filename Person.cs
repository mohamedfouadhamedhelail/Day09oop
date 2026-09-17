using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public virtual decimal Salary { get; set; }

    public void Display()
    {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Age: {Age}");
      Console.WriteLine($"Department: {Department}");
    }

  }
}
