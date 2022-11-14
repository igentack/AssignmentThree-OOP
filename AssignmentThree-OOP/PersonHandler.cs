using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP
{
    internal class PersonHandler
    {
        string firstWord2 = "test2";
        string secondWord2 = "forty2";
        int theAge = 8;
        public void SetAge(Person pers, int age) 
        {
            //Person andra = new Person(firstWord2, secondWord2, theAge);
        
            Console.WriteLine("Try instance");
        }

        internal void SetAge()
        {
            Person andra = new Person(firstWord2, secondWord2, theAge);
            Console.WriteLine("SetAge");
        }
    }
}   

