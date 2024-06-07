using System.Globalization; //for cultureInfo
using System.Reflection; // for AssemblyName.
using System.Reflection.Emit; // for AssemblyBuilder.

WriteLine("This is an ahead-of-time (AOT) compiled console app.");
WriteLine("Current culture: {0}", CultureInfo.CurrentCulture.DisplayName);
WriteLine("OS version: {0}", Environment.OSVersion);
Write("Press any key to exit.");
ReadKey(intercept: true); // Do not output the key that was pressed.

AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(
    new AssemblyName("My Assembly"), AssemblyBuilderAccess.Run);