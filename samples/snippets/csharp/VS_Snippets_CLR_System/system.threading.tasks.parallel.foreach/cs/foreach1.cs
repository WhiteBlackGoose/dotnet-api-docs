// <Snippet1>
using System;
using System.IO;
using System.Threading.Tasks;

public class Example
{
   public static void Main()
   {
      Task<string> task = ReadCharacters(@".\CallOfTheWild.txt");
      string text = task.Result;
      
      int nVowels = 0;
      int nNonWhiteSpace = 0;
      Object obj = new Object();

      ParallelLoopResult result = Parallel.ForEach(text, 
                                                   (ch) => {
                                                      char uCh = char.ToUpper(ch);
                                                      if ("AEIOUY".IndexOf(uCh) >= 0) {
                                                         lock (obj) {
                                                            nVowels++;
                                                         }
                                                      }
                                                      if (! char.IsWhiteSpace(uCh)) {
                                                         lock (obj) {
                                                            nNonWhiteSpace++;
                                                         }   
                                                      }
                                                   } );
      Console.WriteLine("Total characters:      {0,10:N0}", text.Length);
      Console.WriteLine("Total vowels:          {0,10:N0}", nVowels);
      Console.WriteLine("Total non-white-space:  {0,10:N0}", nNonWhiteSpace);
   }

   private static async Task<string> ReadCharacters(string fn)
   {
      string text;
      using (StreamReader sr = new StreamReader(fn)) {
         text = await sr.ReadToEndAsync();
      }
      return text;
   }
}
// The example displays output like the following:
//       Total characters:         198,548
//       Total vowels:              58,421
//       Total non-white-space:     159,461
// </Snippet1>
