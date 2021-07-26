//Types:System.Runtime.InteropServices.ClassInterfaceType
//<snippet1>
using System;
using System.Runtime.InteropServices;

// Have the CLR expose a class interface (derived from IDispatch) for this type.
// COM clients can call the  members of this class using the Invoke method from the IDispatch interface.
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class AClassUsableViaCOM
{
    public AClassUsableViaCOM() { }

    public int Add(int x, int y) { return x + y; }
}

// The CLR does not expose a class interface for this type.
// COM clients can call the members of this class using the methods from the IComparable interface.
[ClassInterface(ClassInterfaceType.None)]
public class AnotherClassUsableViaCOM : IComparable
{
    public AnotherClassUsableViaCOM() { }

    int IComparable.CompareTo(Object o) { return 0; }
}
//</snippet1>
