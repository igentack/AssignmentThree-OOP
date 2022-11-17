using AssignmentThree_OOP.Error;
using AssignmentThree_OOP.Persons;

namespace AssignmentThree_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            PersonHandler personHandler = new PersonHandler();

            string? firstWord = "Wolker";
            string? secondWord = "Brandelius";
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
                               
            }
        }
    }
}
// TODO - Organize project in to folders - DONE
// TODO - Use comments where needed
// TODO - Change variable names + cleanup?
// TODO - Refractor