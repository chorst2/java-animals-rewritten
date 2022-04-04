using System;
using System.Collections.Generic;

namespace java_animals_rewritten
{

    class Program
    {
        static FileOutput OutFile;
        static FileInput InFile;

        static void Main(string[] args)
        {
            OutFile = new FileOutput("animals.txt");
            InFile = new FileInput("animalInput.txt");
            List<Talkable> zoo = new List<Talkable>();

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            foreach(Talkable thing in zoo)
            {
                Console.WriteLine(thing);
            }
            OutFile.FileClose();
            InFile.FileRead();
            InFile.FileClose();

            FileInput Indata = new FileInput("animals.txt");
            string Line;
            while((Line = Indata.FileReadLine()) != null)
            {
                Console.WriteLine(Line);
            }

        }

        // public static void PrintOut(Talkable p)
        // {
        //     Console.WriteLine(p.GetName + " says=" + p.Talk);
        //     OutFile.FileWrite(p.GetName + " | " + p.Talk);
        // }
    }
}