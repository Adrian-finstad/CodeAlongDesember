// See https://aka.ms/new-console-template for more information


using CodeAlongDesember;

var farm = new Farm();
var menu = new Menu();
var animal = new Animal();

farm.AnimalIntroduction();
Console.ReadLine();
menu.MainMenu(farm.animals);
farm.AddAnimal(farm.animals);



