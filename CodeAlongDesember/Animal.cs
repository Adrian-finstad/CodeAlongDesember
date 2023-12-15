using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongDesember
{
    public class Animal
    {
        public string Name { get; set; }
        public string Sound {  get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public Animal()
        {
            
        }
        public void Speak()
        {
            Console.WriteLine($"{Name} Says {Sound}!");
        }


    }
}
