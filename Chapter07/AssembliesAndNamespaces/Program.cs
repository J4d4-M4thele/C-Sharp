using System.Xml.Linq;
using System;

#region Importing Namespaces to use Types
XDocument doc = new();
#endregion

#region C# Keywords and .NET types
string s1 = "Hello";
string s2= "World";
WriteLine($"{s1} {s2}");
#endregion

#region Native Integers
//native ints are platform specific
//32-bit process sizeof() returns 4 bytes
//64-bit process sizeof() returns 8 bytes
WriteLine($"Environment.Is64BitProcess = {Environment.Is64BitProcess}");
WriteLine($"int.MaxValue = {int.MaxValue:N0}");
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");
#endregion

#region

#endregion

#region

#endregion

#region

#endregion