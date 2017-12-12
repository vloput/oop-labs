using System.IO;

namespace Lab13
{
    static class LVIFileInfo
    {
        public static string GetFullPath(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);

                LVILog.AddNote("LVIFileInfo", file.FullName);   //add log note

                return file.FullName;
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }

        public static string GetMainFileInfo(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);
                LVILog.AddNote("LVIFileInfo", file.FullName);   //add log note
                return $"File name: {file.Name}; extension: {file.Extension}; size: " +
                    $"{file.Length / 1024} kb.";
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }

        public static string GetCreationTime(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);
                LVILog.AddNote("LVIFileInfo", file.FullName);   //add log note
                return $"Creation time: {file.CreationTime}";
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }
    }
}
