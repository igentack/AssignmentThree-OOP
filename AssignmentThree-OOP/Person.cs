using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP
{
    internal class Person
    {
        private int weight;
        private int height;
        private string? lName;
        private string? fName;
        private int age;

         
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public int Height
        {
            get { return height; }
            set { height = value; }
        }


        public string? LName
        {
            get { return lName; }
            set
            {
                if (value.ToCharArray().Count() < 3 || value.ToCharArray().Count() > 15)
                {
                    throw new ArgumentException
                    ($"Sorry but the {value} has to be between, 3 and 15 characters.");
                }
                else
                {
                    lName = value;
                }
            }
        }


        public string? FName
        {
            get { return fName; }
            set
            {
                if (value.ToCharArray().Count() < 2 || value.ToCharArray().Count() > 10)
                {
                    throw new ArgumentException
                    ($"Sorry but the {value} has to be between, 2 and 10 characters.");
                }
                else
                {
                    fName = value;
                }
            }
        }


        public int Age
        {
            get { return age; }
            set 
            { 
                if(value <= 0) 
                {
                    throw new ArgumentException
                    ($"{value} is not a valid age, try with a positive value.");
                }
                else
                {
                    age = value; 
                }
            }
        }

        public Person( string fName, string? lName, int age, int weight = 150, int height = 150)
        {
            LName = lName;
            FName = fName;
            Age = age;
            Weight = weight;
            Height = height;
        }
        
        
        public override string ToString()
        {
            return $"Name: {FName} and {Age}";
        }
    }
}



