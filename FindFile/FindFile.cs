using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFile
{
    public class FindFile
    {
        public static List<string> GetDirectories(string startPoint, string fileName, bool exact)
        {
            List<string> toSearch = new List<string>();
            List<string> directories = new List<string>();
            string searchPattern = fileName;
            
            if (!exact)
                searchPattern = "*" + fileName + "*";

            try
            {
                if (Directory.Exists(startPoint))
                {
                    toSearch = Directory.GetDirectories(startPoint).ToList();
                    directories = Directory.GetFiles(startPoint, searchPattern).ToList();
                }

                foreach (var dirToSearch in toSearch)
                {
                    directories.AddRange(FindFile.GetDirectories(dirToSearch, searchPattern, true));
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (DirectoryNotFoundException) { }

            return directories;
        }
    }
}
