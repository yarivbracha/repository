using System;
using System.Collections.Generic;
using System.IO;


namespace FileFinder
{
    class FileFinderHelper
    {
        public Dictionary<string, long> FindWordInFiles(string pathDirectory, string wordToFind)
        {
            Dictionary<string, long> dictionaryFilesAndLength = new Dictionary<string, long>();
            List<string> listFiles = new List<string>();
            listFiles = FindWordRecursivly(listFiles, pathDirectory, wordToFind);
            foreach(string file in listFiles)
            {
                if (File.Exists(file))
                {
                    dictionaryFilesAndLength.Add(file, new FileInfo(file).Length);
                }
            }
            return dictionaryFilesAndLength;
        }

        private List<string> FindWordRecursivly(List<string> listFiles, string pathDirectory, string wordToFind)
        {
            try
            {
                foreach (string file in Directory.GetFiles(pathDirectory))
                {
                    if (file.Contains(wordToFind))
                    {
                        listFiles.Add(file);
                    }
                }
                foreach (string directory in Directory.GetDirectories(pathDirectory))
                {
                    FindWordRecursivly(listFiles, directory, wordToFind);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found, the search continues..");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("The path is too long, the search continues..");
            }
            return listFiles;
        }
    }
}
