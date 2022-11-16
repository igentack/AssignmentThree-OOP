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
                Console.WriteLine("Should have used a double for height aswell - for smoother calc for the BMI method.");
            }

        }
    }
}