using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcharoo
{
    public class SwitchFunction
    {
        SwitchLogic sl = new SwitchLogic();
        public string FlipEndChars(object input)
        {
            if (sl.IsString(input))
            {
                string sinput = Convert.ToString(input);

                if (sl.LenBelowTwo(sinput))
                {
                    return "Incompatible.";
                }
                if (sl.FirstLastIsSame(sinput))
                {
                    return "Two's a pair.";
                }

                return sl.SwitchFirstLast(sinput);
            }
            return "Incompatible.";
        }
    }
}
