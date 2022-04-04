using System;

namespace java_animals_rewritten
{

    class Dog : Pet, Talkable
    {
        public bool Friendly { get; set; }

        public Dog(bool Friendly, string Name): base(Name)
        {
            Friendly = Friendly;
        }

        public bool IsFriendly()
        {
            return Friendly;
        }

        public string Talk()
        {
            return "Bark";
        }
 
        public override string ToString()
        {
            return "Dog: " + "name=" + Name + " Friendly=" + Friendly;
        }

    
    }
}