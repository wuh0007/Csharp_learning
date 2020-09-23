using System;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\haha.jpg";

            // file and file info
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


            // directory and directory info
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\...", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
                

            var directories = Directory.GetDirectories(@"c:\projects\...", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

        }
    }
}
