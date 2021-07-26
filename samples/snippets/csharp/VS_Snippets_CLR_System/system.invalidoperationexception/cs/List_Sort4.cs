// <Snippet15>
using System;
using System.Collections.Generic;

public class Person
{
   public Person(string fName, string lName)
   {
      FirstName = fName;
      LastName = lName;
   }

   public string FirstName { get; set; }
   public string LastName { get; set; }
}

public class Example
{
   public static void Main()
   {
      var people = new List<Person>();

      people.Add(new Person("John", "Doe"));
      people.Add(new Person("Jane", "Doe"));
      people.Sort(PersonComparison);
      foreach (var person in people)
         Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
   }

   public static int PersonComparison(Person x, Person y)
   {
      return string.Format("{0} {1}", x.LastName, x.FirstName).
             CompareTo(string.Format("{0} {1}", y.LastName, y.FirstName));
   }
}
// The example displays the following output:
//       Jane Doe
//       John Doe
// </Snippet15>
