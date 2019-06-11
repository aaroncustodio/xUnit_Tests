using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidation
{
    public class ValidationCondition
    {
        public Boolean ContainsAtDot()
        {
            return false;
        }

        public Boolean CharInFrontOfAt()
        {
            return false;
        }

        public Boolean AtDotInProperPlace()
        {
            return false;
        }
    }
}
