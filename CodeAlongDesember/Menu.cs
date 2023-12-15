using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongDesember
{
    public class Menu
    {
        
       public void MainMenu(List<Animal> animalList)
        {
            Farm farm = new Farm();
            Console.WriteLine("Which animal would you like to make talk?");
            for (int i = 0; i < animalList.Count; i++)
            {
                Console.WriteLine($"{i} {animalList[i].Name}");
            }
            Console.WriteLine("Type the number of the animal you want to speak to?");
            var userInput = int.Parse(Console.ReadLine());
            animalList[userInput].Speak();
            Console.ReadLine();
            Console.WriteLine("Would you like to add another animal?(Y/N)");
            var userInputTwo = Console.ReadLine();
            if(userInputTwo == "Y")
            {
                farm.AddAnimal(animalList);
                MainMenu(animalList);
            }
            else if(userInputTwo == "N")
            {
                MainMenu(animalList);
            }
            
        }

        

    }
}
