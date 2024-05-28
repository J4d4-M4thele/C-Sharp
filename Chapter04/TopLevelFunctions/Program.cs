using static System.Console;

#region High Level Functions
/*
WriteLine("* Top-level funvction examples");

WhatsMyNamespace(); // Call the function.
void WhatsMyNamespace() // Define a local function.
{
    WriteLine("Namespace of Program class: {0}",
    arg0: typeof(Program).Namespace ?? "null");
}
*/
#endregion

#region Local Function
/*
partial class Program
{
    static void <Main>$(String[] args)
{
WriteLine("* Top-level functions example");
<<Main>$>g__WhatsMyNamespace|0_0(); // Call the function.
void <<Main>$>g__WhatsMyNamespace|0_0() // Define a local function.
{
WriteLine("Namespace of Program class: {0}",
arg0: typeof(Program).Namespace ?? "null");
}
}
}
*/
#endregion

#region Partial class Reference
/*
WriteLine("* Top-level functions example");

WhatsMyNameSpace();
*/
#endregion


