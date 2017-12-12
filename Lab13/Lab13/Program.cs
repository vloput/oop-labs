using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LVIDiskInfo

            Console.WriteLine("-------------------- LVIDiskInfo --------------------\n");

            Console.WriteLine($"File system of D: {LVIDiskInfo.GetFileSystem("D")}\n");
            Console.WriteLine($"Free space on D: {LVIDiskInfo.GetFreeSpace("D")} GB\n");
            Console.WriteLine(LVIDiskInfo.GetDisksInfo() + "\n");

            #endregion

            Thread.Sleep(1000);

            #region LVIFileInfo

            Console.WriteLine("-------------------- LVIFileInfo --------------------\n");

            Console.WriteLine($"Hello.txt located at {LVIFileInfo.GetFullPath("Hello.txt")}\n");
            Console.WriteLine($"{LVIFileInfo.GetMainFileInfo("Hello.txt")}\n");
            Console.WriteLine($"{LVIFileInfo.GetCreationTime("Hello.txt")}\n");

            #endregion

            Thread.Sleep(1000);

            #region LVIDirInfo

            Console.WriteLine("-------------------- LVIDirInfo ---------------------\n");

            Console.WriteLine($"Учёба has {LVIDirInfo.GetNumberOfDirectories("D:\\Учёба")} folders\n");
            Console.WriteLine($"Creation time: {LVIDirInfo.GetCreationTime("D:\\Учёба")}\n");
            Console.WriteLine($"Has {LVIDirInfo.GetNumberOfFiles("D:\\Учёба")} files\n");
            Console.WriteLine($"Parent of ООП: {LVIDirInfo.GetParents("D:\\Учёба\\ООП")}\n");

            #endregion
            
            Thread.Sleep(1000);

            #region LVIFileManager

            Console.WriteLine("-------------------- LVIFileManager -----------------\n");

            LVIFileManager.WriteFilesAndFodlers("D");
            LVIFileManager.CopyFilesByExtension("pdf", "D:\\Учёба");
            LVIFileManager.ZipFolder();

            #endregion

        }
    }
}
