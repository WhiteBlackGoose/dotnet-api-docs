using System;

namespace SystemDateTimeReference
{
    public static class stringFormat
    {
        public static void Snippets()
        {
            ShowDefaultTostring();
            ShowCultureSpecificTostring();
            ShowDefaultFullDateAndTime();
            ShowCultureSpecificFullDateAndTime();
            ShowIso8601Format();
        }

        private static void ShowDefaultTostring()
        {
            // <Snippet1>
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.Tostring());
            // For en-US culture, displays 3/1/2008 7:00:00 AM
            // </Snippet1>
        }

        private static void ShowCultureSpecificTostring()
        {
            // <Snippet2>
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.Tostring(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
            // Displays 01/03/2008 07:00:00
            // </Snippet2>
        }

        private static void ShowDefaultFullDateAndTime()
        {
            // <Snippet3>
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.Tostring("F"));
            // Displays Saturday, March 01, 2008 7:00:00 AM
            // </Snippet3>
        }

        private static void ShowCultureSpecificFullDateAndTime()
        {
            // <Snippet4>
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.Tostring("F", new System.Globalization.CultureInfo("fr-FR")));
            // Displays samedi 1 mars 2008 07:00:00
            // </Snippet4>
        }

        private static void ShowIso8601Format()
        {
            // <Snippet5>
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.Tostring("yyyyMMddTHH:mm:ssZ"));
            // Displays 20080301T07:00:00Z
            // </Snippet5>
        }
    }
}
