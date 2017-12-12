using System.IO;

namespace Lab13
{
    static class LVIDirInfo
    {
        public static string GetNumberOfFiles(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);

                LVILog.AddNote("LVIDirInfo", info.FullName);   //add log note
                return info.GetFiles().Length.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetCreationTime(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);

                LVILog.AddNote("LVIDirInfo", info.FullName);   //add log note
                return info.CreationTime.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetNumberOfDirectories(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                LVILog.AddNote("LVIDirInfo", info.FullName);   //add log note
                return info.GetDirectories().Length.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetParents(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                LVILog.AddNote("LVIDirInfo", info.FullName);   //add log note
                return info.Parent.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }
    }
}
