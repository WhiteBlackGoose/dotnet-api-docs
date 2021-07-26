using System;
using System.Collections.Generic;

namespace SystemDateTimeReference
{
    public static class Parsing
    {
        public static void Snippets()
        {
            ParseStandardFormats();
            ParseCustomFormats();
            ParseISO8601();
        }

        private static void ParseStandardFormats()
        {
            // <Snippet1>
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            var date1 = new DateTime(2013, 6, 1, 12, 32, 30);
            var badFormats = new List<string>();

            Console.WriteLine($"{"Date string",-37} {"Date",-19}\n");
            foreach (var datestring in date1.GetDateTimeFormats())
            {
                DateTime parsedDate;
                if (DateTime.TryParse(datestring, out parsedDate))
                    Console.WriteLine($"{datestring,-37} {DateTime.Parse(datestring),-19}");
                else
                    badFormats.Add(datestring);
            }

            // Display strings that could not be parsed.
            if (badFormats.Count > 0)
            {
                Console.WriteLine("\nstrings that could not be parsed: ");
                foreach (var badFormat in badFormats)
                    Console.WriteLine($"   {badFormat}");
            }
            // Press "Run" to see the output.
            // </Snippet1>
        }

        private static void ParseCustomFormats()
        {
            // <Snippet2>
            string[] formats = { "yyyyMMdd", "HHmmss" };
            string[] datestrings = { "20130816", "20131608", "  20130816   ",
                               "115216", "521116", "  115216  " };
            DateTime parsedDate;

            foreach (var datestring in datestrings)
            {
                if (DateTime.TryParseExact(datestring, formats, null,
                                           System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                           System.Globalization.DateTimeStyles.AdjustToUniversal,
                                           out parsedDate))
                    Console.WriteLine($"{datestring} --> {parsedDate:g}");
                else
                    Console.WriteLine($"Cannot convert {datestring}");
            }
            // The example displays the following output:
            //       20130816 --> 8/16/2013 12:00 AM
            //       Cannot convert 20131608
            //         20130816    --> 8/16/2013 12:00 AM
            //       115216 --> 4/22/2013 11:52 AM
            //       Cannot convert 521116
            //         115216   --> 4/22/2013 11:52 AM
            // </Snippet2>
        }
        private static void ParseISO8601()
        {
            // <Snippet3>
            var iso8601string = "20080501T08:30:52Z";
            DateTime dateISO8602 = DateTime.ParseExact(iso8601string, "yyyyMMddTHH:mm:ssZ",
                System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine($"{iso8601string} --> {dateISO8602:g}");
            // </Snippet3>
        }
    }
}
