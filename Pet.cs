using System;

namespace java_animals_rewritten
{

    abstract class Pet
    {
        public string Name { get; set; }

        public Pet(string Name)
        {
            Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}