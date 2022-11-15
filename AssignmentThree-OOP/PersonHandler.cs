using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP
{
    internal class PersonHandler
    {
        string firstWord2 = "Sebastian";
        string secondWord2 = "Sten";
        int theAge = 12;
        public void SetAge(Person pers, int age) 
        {
            
        }

        internal void SetAge()
        {
            Person second = new Person(firstWord2, secondWord2, theAge);
            Console.WriteLine(second.ToString());
        }
    }
}   

