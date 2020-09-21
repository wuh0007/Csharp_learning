using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\haha.jpg";

            File.Copy(@"c:\temp\me.jpg", @"d:\temp\me.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //some codes
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //some codes
            }
        }
    }
}
