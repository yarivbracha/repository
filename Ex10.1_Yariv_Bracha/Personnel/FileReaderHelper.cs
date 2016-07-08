using System;
using System.Collections.Generic;
using System.IO;

namespace Personnel
{
    class FileReaderHelper
    {
        private StreamReader reader;

        public void ReadFileLines(string path)
        {
            string currentLine;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            reader = new StreamReader(fileStream);
            try
            { 
                List<string> fileLines = new List<string>();
                while ((currentLine = reader.ReadLine()) != null)
                {
                    fileLines.Add(currentLine);
                }
                foreach (string line in fileLines)
                {
                    Console.WriteLine(line);
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
