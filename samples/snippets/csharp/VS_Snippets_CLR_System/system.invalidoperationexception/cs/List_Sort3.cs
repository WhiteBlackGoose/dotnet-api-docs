// <Snippet14>
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

public class PersonComparer : IComparer<Person>
{
   public int Compare(Person x, Person y)
   {
      return string.Format("{0} {1}", x.LastName, x.FirstName).
             CompareTo(string.Format("{0} {1}", y.LastName, y.FirstName));
   }
}

public class Example
{
   public static void Main()
   {
      var people = new List<Person>();

      people.Add(new Person("John", "Doe"));
      people.Add(new Person("Jane", "Doe"));
      people.Sort(new PersonComparer());
      foreach (var person in people)
         Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
   }
}
// The example displays the following output:
//       Jane Doe
//       John Doe
// </Snippet14>
