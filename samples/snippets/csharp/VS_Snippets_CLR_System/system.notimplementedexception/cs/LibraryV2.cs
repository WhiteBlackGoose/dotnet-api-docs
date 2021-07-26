// <Snippet3>
namespace Utilities
{
   public class StringLibrary
   {
      public static Version Version { get; } = new Version("2.0");

      public static string GetEndOfLineCharacter()
      {
         return Environment.Newline;
      }
   }
}
// </Snippet3>
