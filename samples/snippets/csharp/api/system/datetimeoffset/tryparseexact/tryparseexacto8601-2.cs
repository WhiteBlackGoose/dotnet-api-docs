using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      string[] datestrings = { "2018-08-18T12:45:16.0000000Z",
                               "2018/08/18T12:45:16.0000000Z",
                               "2018-18-08T12:45:16.0000000Z",
                               "2018-08-18T12:45:16.0000000",                               
                               " 2018-08-18T12:45:16.0000000Z ",
                               "2018-08-18T12:45:16.0000000+02:00",
                               "2018-08-18T12:45:16.0000000-07:00" }; 
      
      ParseWithISO8601(datestrings, DateTimeStyles.None);
      Console.WriteLine("\n-----\n");
      ParseWithISO8601(datestrings, DateTimeStyles.AllowWhiteSpaces);
      Console.WriteLine("\n-----\n");
      ParseWithISO8601(datestrings, DateTimeStyles.AdjustToUniversal);
      Console.WriteLine("\n-----\n");
      ParseWithISO8601(datestrings, DateTimeStyles.AssumeLocal);
      Console.WriteLine("\n-----\n");
      ParseWithISO8601(datestrings, DateTimeStyles.AssumeUniversal);   }

   private static void ParseWithISO8601(string[] datestrings, DateTimeStyles styles)
   {   
      Console.WriteLine($"Parsing with {styles}:");
      DateTimeOffset date;
      foreach (var datestring in datestrings)
      {
         if (DateTimeOffset.TryParseExact(datestring, "O", null, styles, out date))
         {
            Console.WriteLine($"   {datestring,-35} --> {date:yyyy-MM-dd HH:mm:ss.FF zzz}");
         }
         else
         {
            Console.WriteLine($"   Unable to convert '{datestring}'");
         }   
      } 
   }
}
// The example displays the following output:
//      Parsing with None:
//         2018-08-18T12:45:16.0000000Z        --> 2018-08-18 12:45:16 +00:00
//         Unable to convert '2018/08/18T12:45:16.0000000Z'
//         Unable to convert '2018-18-08T12:45:16.0000000Z'
//         2018-08-18T12:45:16.0000000         --> 2018-08-18 12:45:16 -07:00
//         Unable to convert ' 2018-08-18T12:45:16.0000000Z '
//         2018-08-18T12:45:16.0000000+02:00   --> 2018-08-18 12:45:16 +02:00
//         2018-08-18T12:45:16.0000000-07:00   --> 2018-08-18 12:45:16 -07:00
//
//      -----
//
//      Parsing with AllowWhiteSpaces:
//         2018-08-18T12:45:16.0000000Z        --> 2018-08-18 12:45:16 +00:00
//         Unable to convert '2018/08/18T12:45:16.0000000Z'
//         Unable to convert '2018-18-08T12:45:16.0000000Z'
//         2018-08-18T12:45:16.0000000         --> 2018-08-18 12:45:16 -07:00
//          2018-08-18T12:45:16.0000000Z       --> 2018-08-18 12:45:16 +00:00
//         2018-08-18T12:45:16.0000000+02:00   --> 2018-08-18 12:45:16 +02:00
//         2018-08-18T12:45:16.0000000-07:00   --> 2018-08-18 12:45:16 -07:00
//
//      -----
//
//      Parsing with AdjustToUniversal:
//         2018-08-18T12:45:16.0000000Z        --> 2018-08-18 12:45:16 +00:00
//         Unable to convert '2018/08/18T12:45:16.0000000Z'
//         Unable to convert '2018-18-08T12:45:16.0000000Z'
//         2018-08-18T12:45:16.0000000         --> 2018-08-18 19:45:16 +00:00
//         Unable to convert ' 2018-08-18T12:45:16.0000000Z '
//         2018-08-18T12:45:16.0000000+02:00   --> 2018-08-18 10:45:16 +00:00
//         2018-08-18T12:45:16.0000000-07:00   --> 2018-08-18 19:45:16 +00:00
//
//      -----
//
//      Parsing with AssumeLocal:
//         2018-08-18T12:45:16.0000000Z        --> 2018-08-18 12:45:16 +00:00
//         Unable to convert '2018/08/18T12:45:16.0000000Z'
//         Unable to convert '2018-18-08T12:45:16.0000000Z'
//         2018-08-18T12:45:16.0000000         --> 2018-08-18 12:45:16 -07:00
//         Unable to convert ' 2018-08-18T12:45:16.0000000Z '
//         2018-08-18T12:45:16.0000000+02:00   --> 2018-08-18 12:45:16 +02:00
//         2018-08-18T12:45:16.0000000-07:00   --> 2018-08-18 12:45:16 -07:00
//
//      -----
//
//      Parsing with AssumeUniversal:
//         2018-08-18T12:45:16.0000000Z        --> 2018-08-18 12:45:16 +00:00
//         Unable to convert '2018/08/18T12:45:16.0000000Z'
//         Unable to convert '2018-18-08T12:45:16.0000000Z'
//         2018-08-18T12:45:16.0000000         --> 2018-08-18 12:45:16 +00:00
//         Unable to convert ' 2018-08-18T12:45:16.0000000Z '
//         2018-08-18T12:45:16.0000000+02:00   --> 2018-08-18 12:45:16 +02:00
//         2018-08-18T12:45:16.0000000-07:00   --> 2018-08-18 12:45:16 -07:00
