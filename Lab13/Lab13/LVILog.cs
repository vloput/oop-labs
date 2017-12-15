using System;
using System.IO;

namespace Lab13
{
    class LVILog
    {
        public static void AddNote(string utility, string path)
        {
            StreamWriter logFile = new StreamWriter("lvilogfile.txt", true);
            logFile.WriteLine($"{utility} : {path} : {DateTime.Now}");
            logFile.Close();
        }
    }
}
