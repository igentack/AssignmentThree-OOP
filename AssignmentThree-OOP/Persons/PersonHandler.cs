using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentThree_OOP.Persons
{
    internal class PersonHandler
    {

        public Person CreatePerson(string firstWord, string secondWord, int theAge, double weight, int height)
        {
            var person = new Person();
            Console.WriteLine($"{firstWord} {secondWord} weighs in at {weight} kg and is {theAge} years young\n");
            Bmi(weight, height);
            return person;

        }
        public void SetAge(Person firstWord, int theAge)
        {
            firstWord.Age = theAge;
            Console.WriteLine($"This is after reassigning the age, and the new age is {firstWord.Age}.\n");

        }

        public static void Bmi(double weight, int height)
        {
            double bmiResult = Math.Round(100 * (weight / (height * height / 100)), 2);
            Console.WriteLine($"... and his BMI is {bmiResult}.\n");
        }
    }
}

