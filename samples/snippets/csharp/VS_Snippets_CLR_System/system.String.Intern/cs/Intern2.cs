using System;
using System.Text;

[assembly: CLSCompliant(true)]
public class Class1
{
   public static void Main()
   {
      // <Snippet2>
		string str1 = string.Empty;
		string str2 = string.Empty;

		StringBuilder sb = new StringBuilder().Append(string.Empty);
		str2 = string.Intern(sb.ToString());	
		
		if((object)str1==(object)str2)
			Console.WriteLine("The strings are equal.");
		else
			Console.WriteLine("The strings are not equal.");
		// </Snippet2>	
   }
}
