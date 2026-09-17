using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09oop
{
   class Department
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
      if (obj is Department other)
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
      return Name;
    }








  }
}
