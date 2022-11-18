using AssignmentThree_OOP.Error;
using AssignmentThree_OOP.Persons;
using AssignmentThree_OOP.Animals;
using System.Collections.Generic;
using AssignmentThree_OOP.Utils;

namespace AssignmentThree_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* PersonHandler personHandler = new PersonHandler();

            string firstWord = "Wolker";
            string secondWord = "Brandelius";
            int theAge = 63;
            int ageTwo = 45;
            double weight = 87.7;
            int height = 170;

            try
            {
                var person = personHandler.CreatePerson(firstWord, secondWord, theAge, weight, height);
                personHandler.SetAge(person, ageTwo);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Should have used a double for height aswell - for smoother calc for the BMI method.\n");
            }

            var errors = new List<UserError>();

            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new CapitalInputError());
            errors.Add(new WrongPassword());
            errors.Add(new NightOwling());

            foreach (var error in errors)
            {
                string value = error.UEMessage();
                Console.WriteLine($"{value}\n");

            }*/


            var animals = new List<Animal>();
            animals.Add(new Animal.Horse("HarryHäst", 1, 12, "Havre"));
            animals.Add(new Animal.Dog("HobbeHund", 2, 9, "Brun"));
            animals.Add(new Animal.HedgeHog("IvarIgelkott", 3, 2, "Infinite"));
            animals.Add(new Animal.Worm("SirVääs", 4, 3, "Borde varit int 170cm"));
            animals.Add(new Animal.Bird("Djingis", 5, 1500, "Borde varit int också 3m"));
            animals.Add(new Animal.Pelican("Dino", 6, 15, "Missat intarna :( (copy paste syndrome)", "Green"));
            animals.Add(new Animal.Flamingo("Kyoto", 7, 33, "Hm", false));
            animals.Add(new Animal.Swan("Trulle", 8, 87, "180cm", true));
            animals.Add(new Animal.Wolf("Keanu", 9, 878, "GreyBlue"));
            animals.Add(new Animal.Wolfman("Bert Karlsson", 10, 450, "Röda"));
            animals.Add(new Animal.Dog("HobbeHund", 11, 9, "Brun"));
         


            foreach (var animal in animals)
            {
                if (animal is IPerson)
                {
                    var temp = animal as IPerson;
                    Console.WriteLine(temp.Talk());
                }

                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
                //Console.WriteLine(animal.ValFritt());

            }

        }
    }
}
// TODO - Organize project in to folders - DONE
// TODO - Use comments where needed
// TODO - Change variable names + cleanup?
// TODO - Refactor