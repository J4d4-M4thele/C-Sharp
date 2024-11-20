using System.Diagnostics; //debugs and traces

#region Writing Lines to Debug
Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");
#endregion

#region Trace Listeners
string logPath = Path.Combine(Environment
    .GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to : {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG
// Text writer is buffered, so this option calls
// Flush() on all listeners after writing.
Trace.AutoFlush = true;
#endif
Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

Debug.Close();
Trace.Close();
#endregion

#region Using external Functions
int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);
// Close the text file (also flushes) and release resources.
Debug.Close();
Trace.Close();
#endregion
