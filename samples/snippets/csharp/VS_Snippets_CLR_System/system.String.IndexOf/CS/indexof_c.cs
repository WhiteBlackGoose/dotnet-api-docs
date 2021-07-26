using System;

class Example
{
    static void Main()
    {
        // <Snippet5>
        // Create a Unicode string with 5 Greek Alpha characters.
        string szGreekAlpha = new string('\u0391',5);

        // Create a Unicode string with 3 Greek Omega characters.
        string szGreekOmega = "\u03A9\u03A9\u03A9";

        string szGreekLetters = string.Concat(szGreekOmega, szGreekAlpha, 
                                            szGreekOmega.Clone());

        // Display the entire string.
        Console.WriteLine("The string: {0}", szGreekLetters);

        // The first index of Alpha.
        int ialpha = szGreekLetters.IndexOf('\u0391');
        // The first index of Omega.
        int iomega = szGreekLetters.IndexOf('\u03A9');

        Console.WriteLine("First occurrence of the Greek letter Alpha: Index {0}", 
                        ialpha);
        Console.WriteLine("First occurrence of the Greek letter Omega: Index {0}", 
                        iomega);

        // The example displays the following output:
        //    The string: ΩΩΩΑΑΑΑΑΩΩΩ
        //    First occurrence of the Greek letter Alpha: Index 3
        //    First occurrence of the Greek letter Omega: Index 0
        // </Snippet5>
    }
}
