using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcharoo
{
    public class SwitchLogic
    {
        public Boolean LenBelowTwo(string input)
        {
            return input.Length < 2;
        }

        public Boolean IsString(object input)
        {
            if (!(input is string))
            {
                //throw new ArgumentException("Input is not a string.", "input");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean FirstLastIsSame(string input)
        {
            return input[0] == input[input.Length - 1];
        }

        public string SwitchFirstLast(string input)
        {
            char[] inpArr = input.ToCharArray();

            char firstChar = inpArr[0];

            inpArr[0] = inpArr[inpArr.Count() - 1];
            inpArr[inpArr.Count() - 1] = firstChar;

            return string.Concat(inpArr); //inpArr.ToString();
        }
    }
}
