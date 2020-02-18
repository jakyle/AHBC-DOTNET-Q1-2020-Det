using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    public class FileUtility
    {
        public static IEnumerable<string> ReadFromFile(string path)
        {
            var fileLines = new List<string>();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    fileLines.Add(sr.ReadLine());
                }
            }

            return fileLines;
        }

        public static void CreateFile(string path)
        {
            File.Create(path);
        }

        public static void ModifyExistingFile(string path, IEnumerable<string> additionalLines, bool append)
        {
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                foreach (var line in additionalLines)
                {
                    sw.WriteLine(line);
                }
            }
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}
