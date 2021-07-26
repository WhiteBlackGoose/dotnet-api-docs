// <Snippet1>
using System;

public class Example
{
   public static void Main()
   {
      Array values = Array.CreateInstance(typeof(int), new int[] { 10 },
                                          new int[] { 1 });
      int value = 2;
      // Assign values.
      for (int ctr = 0; ctr < values.Length; ctr++) {
         values.SetValue(value, ctr);
         value *= 2;
      }

      // Display values.
      for (int ctr = 0; ctr < values.Length; ctr++)
         Console.Write("{0}    ", values.GetValue(ctr));
   }
}
// The example displays the following output:
//    Unhandled Exception:
//    System.IndexOutOfRangeException: Index was outside the bounds of the array.
//       at System.Array.InternalGetReference(Void* elemRef, int rank, int* pIndices)
//       at System.Array.SetValue(Object value, int index)
//       at Example.Main()
// </Snippet1>
