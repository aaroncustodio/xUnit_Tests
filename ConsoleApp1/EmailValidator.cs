using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    public class EmailValidator
    {
        ValidationCondition vc = new ValidationCondition();
        public Boolean ValidateEmail(string email)
        {
            return vc.ContainsAtDot(email) &&
                vc.CharBeforeAt(email) &&
                vc.AtDotInProperPlace(email);
        }
    }
}
