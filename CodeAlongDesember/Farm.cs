using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongDesember
{
    public class Farm
    {
        Menu menu = new Menu();

       public List<Animal> animals = new List<Animal>()
       {
          new Animal("Dog", "Voff!"),
          new Animal("Cow", "Moo!"),
          new Animal("Sheep", "Bææ"),
          new Animal("Horse", "IHIHIHI"),
       };

        

        public void AnimalIntroduction()
        {
            Console.WriteLine("Welcome to the farm!");
            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }

        public void AddAnimal(List<Animal> newAnimals)
        {
            Animal newAnimal = new Animal();

            Console.WriteLine("Please type in the name of the animal you wish to ass.(I.e: Cat, Mouse, etc)");
            newAnimal.Name = Console.ReadLine();

            Console.WriteLine("Please type in the sound your animal makes.");
            newAnimal.Sound = Console.ReadLine();

            animals.Add(newAnimal);

            menu.MainMenu(animals);
        }


    }
}
