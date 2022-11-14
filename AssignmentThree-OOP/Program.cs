namespace AssignmentThree_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "three";
            string secondWord = "forty";
            int theAge = 6;
            
            try
            {
                Person test = new Person(firstWord, secondWord, theAge);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("It worked worked");
            }
            
            // Person.ToString();
        }
    }
}