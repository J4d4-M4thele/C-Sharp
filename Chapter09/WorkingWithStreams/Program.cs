using Packt.Shared;
using System.Xml; //for XmlWriter

#region Text Streams
/*
SectionTitle("Writing to text streams");

//file to write to
string textFile = Combine(CurrentDirectory, "streams.txt");
//text file
StreamWriter text = File.CreateText(textFile);

foreach (string item in Viper.Callsigns)
{
    text.WriteLine(item);
}
text.Close();

OutputFileInfo(textFile);
*/
#endregion

#region XML Streams
/*
SectionTitle("Writing to XML streams");

//file path
string xmlFile = Combine(CurrentDirectory, "streams.xml");

//declare variables
FileStream? xmlFileStream = null;
XmlWriter? xml = null;

try 
{
    xmlFileStream = File.Create(xmlFile);
    xml = XmlWriter.Create(xmlFileStream,
new XmlWriterSettings { Indent = true });
    // Write the XML declaration.
    xml.WriteStartDocument();
    // Write a root element.
    xml.WriteStartElement("callsigns");
    // Enumerate the strings, writing each one to the stream.
    foreach (string item in Viper.Callsigns)
    {
        xml.WriteElementString("callsign", item);
    }
    // Write the close root element.
    xml.WriteEndElement();
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
finally 
{
    if (xml is not null)
    {
        xml.Close();
        WriteLine("The XML writer's unmanaged resources have been disposed.");
}
    if (xmlFileStream is not null)
    {
        xmlFileStream.Close();
        WriteLine("The file stream's unmanaged resources have been disposed.");
    }
}
OutputFileInfo(xmlFile);
*/
#endregion

#region Compressing Streams
SectionTitle("Compressing streams");
Compress(algorithm: "gzip");
Compress(algorithm: "brotli");
#endregion

