using AssignmentThree_OOP.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree_OOP.Error
{
    abstract class UserError
    {
        public abstract string UEMessage();
        
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text" +
                   $" only field. This fired an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a" +
                   $" numeric only field. This fired an error!";
        }
    }

    class CapitalInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use only capital letters, and" +
                   $" that caused this ERROR!";
        }
    }

    class WrongPassword : UserError
    {
        public override string UEMessage()
        {
            return $"Sorry, wrong Password - please try again!";
        }
    }

    class NightOwling : UserError
    {
        public override string UEMessage()
        {
            return $"Ooups! I missed the goal, try again!!!";
        }
    }

}