using Microsoft.Win32.SafeHandles;//for SafeFileHandle
using System.Text;// for Encoding
using SafeFileHandle handle = File.OpenHandle(path: "coffee.txt",
mode: FileMode.OpenOrCreate,
access: FileAccess.ReadWrite);

#region Reading and writing with random access handles
//writing text embedded as a byte array
string message = "Café £4.39";
ReadOnlyMemory<byte> buffer = new(Encoding.UTF8.GetBytes(message));
await RandomAccess.WriteAsync(handle, buffer, fileOffset: 0);

//reading from file
long length = RandomAccess.GetLength(handle);
Memory<byte> contentBytes = new(new byte[length]);
await RandomAccess.ReadAsync(handle, contentBytes, fileOffset: 0);
string content = Encoding.UTF8.GetString(contentBytes.ToArray());
WriteLine($"Content of the file: {content}");
#endregion
