using System;
using System.IO;

namespace java_animals_rewritten
{

    class FileInput
    {
        public string FileName { get; set; }
        private StreamReader sr;

        public FileInput(string FileName)
        {
            FileName = FileName;
            sr = new StreamReader(FileName);
        }

        public void FileRead()
        {
            string Line;
            while (!sr.EndOfStream)
            {
                Line = sr.ReadLine();
                Console.WriteLine(Line);
            }
        }

        public string FileReadLine()
        {
            string Line;
            Line = sr.ReadLine();
            return Line;
        }

        public void FileClose()
        {
            if (sr != null)
            {
                sr.Close();
            }
        }
    }
}