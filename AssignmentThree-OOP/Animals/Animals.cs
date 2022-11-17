using AssignmentThree_OOP.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP.Animals
{
    public abstract class Animals
    {

        public string? Name { get; set; }
        public int Wieght { get; set; }
        public int Age { get; set; }


        public abstract string DoSound();

        protected Animals(string? name, int wieght, int age)
        {
            Name = name;
            Wieght = wieght;
            Age = age;
        }


        class Horse : Animals
        {
            public string Food { get; set; }
            public Horse(string? name, int wieght, int age, string food) : base(name, wieght, age)
            {
                Food = food;
            }
            public override string DoSound()
            {
                return $"*IIIääää*";
            }

        }

        class Dog : Animals
        {
            public string FurColor { get; set; }

            public Dog(string? name, int wieght, int age, string furColor) : base(name, wieght, age)
            {
                FurColor = furColor;
            }
            public override string DoSound()
            {
                return $"*Voooff hihi (trött)*";
            }

        }

        class HedgeHog : Animals
        {
            public string NrOfSpikes { get; set; }
            public HedgeHog(string? name, int wieght, int age, string nrOfSpikes) : base(name, wieght, age)
            {
                NrOfSpikes = nrOfSpikes;
            }
            public override string DoSound()
            {
                return $"*krishkrish*";
            }
        }
           
        class Worm : Animals
        {
            public string Length { get; set; }
            public Worm(string? name, int wieght, int age, string length) : base(name, wieght, age)
            {
                Length = length;
            }
            public override string DoSound()
            {
                return $"*shiiiiii*";
            }

        }

        class Bird : Animals
        {
            public string WingSpan { get; set; }
            public Bird(string? name, int wieght, int age, string wingSpan) : base(name, wieght, age)
            {
                WingSpan = wingSpan;
            }

            public override string DoSound()
            {
                return $"*kvikvikvi*";
            }

        }

            // Får ej in en ny unik egenskap när jag ärver från Bird - ordnade "sealed" på funktionen - men hjärnan har gått på lunch just nu, förmodligen enkelt - men måste söva. 
            class Pelican : Bird
            {
            public string Color { get; set; }
            
            public Pelican(string? name, int wieght, int age, string color, string wingSpan) : base(name, wieght, age)
            {
                Color = color;
            }

            public sealed override string DoSound()
                {
                    return $"*kväkväkvä*";
                }

            }

        class Wolf : Animals
        {
            public string EyeColor { get; set; }
            public Wolf(string? name, int wieght, int age, string eyeColor) : base(name, wieght, age)
            {
                EyeColor = eyeColor;
            }
            public override string DoSound()
            {
                return $"*Whooorff*";
            }

        }






    }
}

     