using System;

namespace java_animals_rewritten
{

    abstract class Person
    {

        public string Name { get; set; }

        public Person(string Name)
        {
            Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public static void SetName(string Name)
        {
            Name = Name;
        }
    }
}