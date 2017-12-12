using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    class LVIFileManager
    {
        public static void WriteFilesAndFodlers(string driveName)
        {
            Directory.CreateDirectory("LVIInspect");
            StreamWriter streamWriter = new StreamWriter("LVIInspect\\lvidirinfo.txt");

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo($"{driveName}:\\");

                //Dirs
                foreach (var item in directoryInfo.EnumerateDirectories())
                {
                    streamWriter.WriteLine(item.Name);
                }

                //Files
                foreach (var item in directoryInfo.EnumerateFiles())
                {
                    streamWriter.WriteLine(item.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            streamWriter.Close();
        }

        public static void CopyFilesByExtension(string extension, string path)
        {
            Directory.CreateDirectory("LVIFiles");

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (var item in directory.GetFiles())
            {
                if (item.Name.EndsWith(extension))
                {
                    item.CopyTo($"LVIFiles\\{item.Name}");
                }
            }

            Directory.Move("LVIFiles", "LVIInspect\\LVIFiles");
        }
        
        public static void ZipFolder()
        {
            ZipFile.CreateFromDirectory("LVIInspect\\LVIFiles", @"D:\Учёба\ООП\Lab13\Lab13\bin\Debug\LVIFiles.zip");
        }
    }
}
