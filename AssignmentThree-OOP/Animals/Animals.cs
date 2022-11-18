using AssignmentThree_OOP.Error;
using AssignmentThree_OOP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP.Animals
{
    public abstract class Animal
    {

        public string? Name { get; set; }
        public int Wieght { get; set; }
        public int Age { get; set; }


        public abstract string DoSound();
       /* public virtual string ValFritt()
        {
            return $"Här kommer en valfri sträng.";
        }*/


        public virtual string Stats()
        {
            return$"{Name}, {Wieght} and {Age}";    
        }

        public Animal(string name, int wieght, int age)
        {
            Name = name;
            Wieght = wieght;
            Age = age;
        }


        public class Horse  : Animal
        {
            public string Food { get; set; }
            public Horse(string name, int wieght, int age, string food) : base(name, wieght, age)
            {
                Food = food;
            }
            public override string DoSound()
            {
                return $"*IIIääää*";
            }

            public override string Stats()
            {
                return base.Stats();
            }
        }

        public class Dog : Animal
        {
            public string FurColor { get; set; }

            public Dog(string name, int wieght, int age, string furColor) : base(name, wieght, age)
            {
                FurColor = furColor;
            }
            public string valFritt()
            {
                return $"Här kommer en valfri sträng.";
            }
            public override string DoSound()
            {
                return $"*Voooff*";
            }
            public override string Stats()
            {
                return base.Stats();
            }

        }

        public class HedgeHog : Animal
        {
            public string NrOfSpikes { get; set; }
            public HedgeHog(string name, int wieght, int age, string nrOfSpikes) : base(name, wieght, age)
            {
                NrOfSpikes = nrOfSpikes;
            }
            public override string DoSound()
            {
                return $"*krishkrish*";
            }
            public override string Stats()
            {
                return base.Stats();
            }
        }
           
        public class Worm : Animal
        {
            public string Length { get; set; }
            public Worm(string name, int wieght, int age, string length) : base(name, wieght, age)
            {
                Length = length;
            }
            public override string DoSound()
            {
                return $"*shiiiiii*";
            }
            public override string Stats()
            {
                return base.Stats();
            }

        }

        public class Bird : Animal
        {
            public string WingSpan { get; set; }
            public Bird(string name, int wieght, int age, string wingSpan) : base(name, wieght, age)
            {
                WingSpan = wingSpan;
            }


            public override string DoSound()
            {
                return $"*kvikvikvi*";
            }
            public override string Stats()
            {
                return base.Stats();
            }

        }

            public class Pelican : Bird
            {

                public string Color { get; set; }

                public Pelican(string name, int wieght, int age, string wingSpan, string color) : base(name, wieght, age, wingSpan)
                {
                    Color = color;
                }

                public sealed override string DoSound()
                {
                    return $"*kväkväkvä*";
                }
                public sealed override string Stats()
                {
                    return base.Stats();
                }

        }

            public class Flamingo : Bird
            {
                public bool Tame { get; set; }

                public Flamingo(string name, int wieght, int age, string wingSpan, bool tame) : base(name, wieght, age, wingSpan)
                {
                    Tame = true;
                }

                public sealed override string DoSound()
                {
                    return $"*lololo*";
                }
                public sealed override string Stats()
                {
                    return base.Stats();
                }

        }

            public class Swan : Bird
            {
                public bool hasSpouse { get; set; }

                public Swan(string name, int wieght, int age, string wingSpan, bool hasSpouse ) : base(name, wieght, age, wingSpan)
                {
                    hasSpouse = true;   
                }

                public sealed override string DoSound()
                {
                    return $"*kvääääkkväääk*";
                }
                public sealed override string Stats()
                {
                    return base.Stats();
                }
        }

        public class Wolf : Animal
        {
            public string EyeColor { get; set; }
            public Wolf(string name, int wieght, int age, string eyeColor) : base(name, wieght, age)
            {
                EyeColor = eyeColor;
            }
            public override string DoSound()
            {
                return $"*Whooorff*";
            }
            public override string Stats()
            {
                return base.Stats();
            }

        }

            public class Wolfman : Wolf, IPerson
        {
            public Wolfman(string name, int wieght, int age, string eyeColor) : base(name, wieght, age, eyeColor)
            {
            }

            public string Talk()
            {
                return $"Var är Carola!? Och varför är jag ej med i Melodifestivalen?";
            }
            public sealed override string Stats()
            {
                return base.Stats();
            }
        }
    
    }
}

     