using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidation
{
    public class ValidationCondition
    {
        public Boolean ContainsAtDot(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        public Boolean CharBeforeAt(string email)
        {
            email = email.Trim();
            int index = email.LastIndexOf("@");
            

            //!String.IsNullOrWhiteSpace(CharBeforeAt)
            if (index > 0)
            {
                string CharBeforeAt = email[index - 1].ToString();

                return !String.IsNullOrWhiteSpace(CharBeforeAt); //CharBeforeAt != " ";
            }
            else
            {
                return false;
            }
        }

        public Boolean AtDotInProperPlace(string email)
        {
            int AtIndex = email.LastIndexOf("@");
            int DotIndex = email.LastIndexOf(".");

            return DotIndex > AtIndex;
        }
    }
}
