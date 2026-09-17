using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day09oop
{


  internal class Program
  {
    //problem1
    enum Weekdays
    {
      Monday = 1,
      Tuesday,
      Wednesday,
      Thursday,
      Friday
    }
    //promblem2
    enum Grades : short
    {
      F = -1,
      D,
      C,
      B,
      A
    }
    //problem7
    enum Gender : byte
    {
      Male,
      Female
    }

    //problem9
    enum Gradees : short
    {
      F = -1,
      D,
      C,
      B,
      A
    }
    struct Rectangle
    {
      public double Length { get; set; }
      public double Width { get; set; }


      static void Swap(
    ref Rectangle first,
    ref Rectangle second)
      {
        Rectangle temp = first;

        first = second;
        second = temp;
      }
      
    }
    struct CircleStruct
    {
      public double Radius { get; set; }
      public string Color { get; set; }

      public static bool operator ==(
          CircleStruct first,
          CircleStruct second)
      {
        return first.Radius == second.Radius &&
               first.Color == second.Color;
      }

      public static bool operator !=(
          CircleStruct first,
          CircleStruct second)
      {
        return !(first == second);
      }

      public override bool Equals(object obj)
      {
        if (obj is CircleStruct other)
        {
          return Radius == other.Radius &&
                 Color == other.Color;
        }

        return false;
      }

      public override int GetHashCode()
      {
        return HashCode.Combine(Radius, Color);
      }
    }





    static void Main(string[] args)
    {
      foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
      {
        Console.WriteLine($"{day} = {(int)day}");
      }
      //problem1
      //Explicitly assigning values makes enum values predictable and prevents unexpected changes if members are added or reordered.

      //problem2
      foreach (Grades grade in Enum.GetValues(typeof(Grades)))
      {
        Console.WriteLine($"{grade} = {(short)grade}");
      }

      //لو عملنا:
      /*
      enum Grades : short
          {
            F = -1,
            A = 40000
          }

          هيحصل compile-time error لأن short مداه:

      -32,768 → 32,767
      */

      //perblem3
      Person person1 = new Person
      {
        Name = "Mohamed",
        Age = 20,
        Department = "IT"
      };

      Person person2 = new Person
      {
        Name = "Ahmed",
        Age = 22,
        Department = "HR"
      };

      person1.Display();

      Console.WriteLine();

      person2.Display();
      //The virtual keyword allows a derived class to override the property and provide its own implementation.

      //problem4
      Child child = new Child();

      child.Salary = 10000;

      child.DisplaySalary();

      //Because sealed prevents further overriding of the property or method in derived classes.

      //problem5
      double result = Utility.RectanglePerimeter(10, 5);

      Console.WriteLine($"Perimeter = {result}");

      //Static members belong to the class itself, while instance members belong to an object created from the class.

      //problem6

      ComplexNumber c1 = new ComplexNumber(2, 3);
      ComplexNumber c2 = new ComplexNumber(4, 5);

      ComplexNumber result1 = c1 * c2;

      Console.WriteLine(result1);
      //No. C# allows overloading many operators, but some operators cannot be overloaded, such as ., ?:, and ::.

      //problem7
      Console.WriteLine($"Default int size: {sizeof(int)} byte");
      Console.WriteLine($"Byte size: {sizeof(byte)} byte");

      Gender gender = Gender.Male;

      Console.WriteLine($"Gender: {gender}");
      Console.WriteLine($"Value: {(byte)gender}");
      //When memory usage matters and the enum values can fit within a smaller underlying type such as byte or short.

      //problem8

      double fahrenheit = Utility.CelsiusToFahrenheit(25);
      Console.WriteLine($"25 C = {fahrenheit} F");

      double celsius = Utility.FahrenheitToCelsius(77);
      Console.WriteLine($"77 F = {celsius} C");
      //A static class cannot be instantiated, so it cannot have an instance constructor.

      //problem9

      Console.Write("Enter grade: ");

      string input = Console.ReadLine();

      if (Enum.TryParse<Gradees>(input, true, out Gradees grade))
      {
        Console.WriteLine($"Valid grade: {grade}");
        Console.WriteLine($"Value: {(short)grade}");
      }
      else
      {
        Console.WriteLine("Invalid grade.");
      }

      //Enum.TryParse safely attempts to convert a string to an enum and returns false instead of throwing an exception when the input cannot be parsed.

      //problem10
      Employee[] employees =
       {
            new Employee { Id = 1, Name = "Mohamed" },
            new Employee { Id = 2, Name = "Ahmed" },
            new Employee { Id = 3, Name = "Ali" }
        };

      Employee searchEmployee =
          new Employee { Id = 2, Name = "Another Name" };

      int index =
          Helper2<Employee>.SearchArray(
              employees,
              searchEmployee);

      Console.WriteLine($"Index = {index}");
    }
    /*
     
     Equals() method يمكن override لها لتحديد value equality.
== operator له سلوك مختلف حسب النوع.
بالنسبة للـ class، == افتراضيًا يقارن references.
بالنسبة للـ struct، لا يوجد == تلقائيًا للـ user-defined struct؛ لو عايز تستخدمه لازم تعمل operator overload.
     
     
     */
    //problem11
    Employee employee = new Employee
    {
      Id = 1,
      Name = "Mohamed"
    };

    Console.WriteLine(employee);

      //Overriding ToString provides a meaningful string representation of an object, which is useful for displaying, debugging, and logging.

      //problem12

      int maxInt = Helper.Max(10, 20);

    double maxDouble = Helper.Max(5.5, 3.2);

    string maxString = Helper.Max("Apple", "Banana");

    Console.WriteLine(maxInt);
        Console.WriteLine(maxDouble);
        Console.WriteLine(maxString);

      //problem13
     
      int[] numbers = { 1, 2, 3, 2, 4 };

    Helper2<int>.ReplaceArray(
        numbers,
    2,
    99);

foreach (int number in numbers)

    Console.WriteLine(number);


  //problem14
  Rectangle r1 = new Rectangle
  {
    Length = 10,
    Width = 5
  };

    Rectangle r2 = new Rectangle
    {
      Length = 20,
      Width = 15
    };

    Console.WriteLine(
            $"Before: {r1.Length}, {r2.Length}");

        Swap(ref r1, ref r2);

    Console.WriteLine(
            $"After: {r1.Length}, {r2.Length}");


      //problem15
      Department it = new Department
      {
        Id = 1,
        Name = "IT"
      };

    Department hr = new Department
    {
      Id = 2,
      Name = "HR"
    };

    Employee[] employees =
    {
    new Employee
    {
        Id = 1,
        Name = "Mohamed",
        Department = it
    },

    new Employee
    {
        Id = 2,
        Name = "Ahmed",
        Department = hr
    }
};
    //problem16

    CircleStruct c1 = new CircleStruct
    {
      Radius = 5,
      Color = "Red"
    };

    CircleStruct c2 = new CircleStruct
    {
      Radius = 5,
      Color = "Red"
    };

    Console.WriteLine(c1 == c2);
Console.WriteLine(c1.Equals(c2));

      /*C# does not automatically define == for user-defined structs because the language cannot assume what equality should mean for every custom struct.*/





























  }


}

   













 

