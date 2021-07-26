// System.Reflection.Emit.ModuleBuilder.DefineResource(string,String)

/*
The following example demonstrates the 'DefineResource(string,String)' method
of 'ModuleBuilder' class.
A dynamic assembly with a module in it is created in 'CodeGenerator' class.
Then a managed resource is defined in the module using the 'DefineResource'
method.
*/
// <Snippet1>
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;

   public class CodeGenerator
   {
      public CodeGenerator()
      {
         // Get the current application domain for the current thread.
         AppDomain currentDomain = AppDomain.CurrentDomain;

         AssemblyName myAssemblyName = new AssemblyName();
         myAssemblyName.Name = "TempAssembly";

         // Define 'TempAssembly' assembly in the current application domain.
         AssemblyBuilder myAssemblyBuilder =
            currentDomain.DefineDynamicAssembly
                        (myAssemblyName, AssemblyBuilderAccess.RunAndSave);
         // Define 'TempModule' module in 'TempAssembly' assembly.
         ModuleBuilder myModuleBuilder =
            myAssemblyBuilder.DefineDynamicModule("TempModule",
                                       "TempModule.netmodule",true);
         // Define the managed embedded resource, 'MyResource' in 'TempModule'.
         IResourceWriter myResourceWriter =
               myModuleBuilder.DefineResource("MyResource.resource","Description");
         // Add resources to the resource writer.
         myResourceWriter.AddResource("string 1", "First string");
         myResourceWriter.AddResource("string 2", "Second string");
         myResourceWriter.AddResource("string 3", "Third string");
         myAssemblyBuilder.Save("MyAssembly.dll");
      }
   }

   public class CallerClass
   {
      public static void Main()
      {
         CodeGenerator myGenerator = new CodeGenerator();
         Console.WriteLine("A resource named 'MyResource.resource'"
                +" has been created and can be viewed  in the 'MyAssembly.dll'");
      }
   }
// </Snippet1>