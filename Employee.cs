using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Employee
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }

    public override bool Equals(object obj)
    {
      if (obj is Employee other)
      {
        return Id == other.Id;
      }

      return false;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
    public override string ToString()
    {
      return $"{Id} - {Name}";
    }





  }
}
