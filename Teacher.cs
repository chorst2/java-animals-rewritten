using System;

namespace java_animals_rewritten
{

    class Teacher : Person, Talkable
    {
        public int Age{ get; set; }

        public Teacher(int Age, string Name): base(Name)
        {
            Age = Age;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int Age)
        {
            Age = Age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}