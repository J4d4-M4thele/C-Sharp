using static System.Console;

namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma()//public can be called from outside
    {
        WriteLine("In Gamma");
    }

    private static void Delta()// private can only be called internally
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}
