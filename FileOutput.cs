using System;
using System.IO;

namespace java_animals_rewritten
{

    class FileOutput
    {
        public string FileName { get; set; }
        private StreamWriter sw;

        public FileOutput(string FileName)
        {
            FileName = FileName;
            sw = new StreamWriter(FileName);
        }

        public void FileWrite(string Line)
        {
            sw.WriteLine(Line);
        }

        public void FileClose()
        {
            if (sw != null)
            {
                sw.Close();
            }
        }
    }
}