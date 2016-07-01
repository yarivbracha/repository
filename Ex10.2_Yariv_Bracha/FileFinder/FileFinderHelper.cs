using System.Collections.Generic;
using System.IO;


namespace FileFinder
{
    class FileFinderHelper
    {
        string[] files;
        StreamReader reader;

        public Dictionary<string, long> FindWordInFiles(string pathDirectory, string wordToFind)
        {
            string[] files = Directory.GetFiles(pathDirectory);
            Dictionary<string, long> dictionaryFilesInfo = new Dictionary<string, long>();
            for(int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i]))
                {
                    try
                    {
                        FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read, FileShare.Read);
                        reader = new StreamReader(fileStream);
                        if (files[i].Contains(wordToFind))
                        {
                            FileInfo fileInfo = new FileInfo(files[i]);
                            long fileLength = fileInfo.Length;
                            dictionaryFilesInfo.Add(files[i], fileLength);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
                else
                {
                    continue;
                }
            }
            return dictionaryFilesInfo;
        }
    }
}
