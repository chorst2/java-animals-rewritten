using System;

namespace java_animals_rewritten
{

    class Cat : Pet, Talkable
    {
        public int MousesKilled { get; set; }

        public Cat(int MousesKilled, string Name): base(Name)
        {
            MousesKilled = MousesKilled;
        }

        public int GetMousesKilled()
        {
            return MousesKilled;
        }

        public void AddMouse(){
            MousesKilled = MousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }
 
        public override string ToString()
        {
            return "Cat: " + "name=" + this.Name + " MousesKilled=" + MousesKilled;
        }

    
    }
}