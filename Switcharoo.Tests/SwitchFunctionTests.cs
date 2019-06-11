using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switcharoo;
using Xunit;
    
namespace Switcharoo.Tests
{
    public class SwitchFunctionTests
    {
        SwitchFunction sf = new SwitchFunction();

        [Theory]
        [InlineData("Cat, dog, and mouse.", ".at, dog, and mouseC")]
        [InlineData("Anna, Banana", "anna, BananA")]
        [InlineData("[]", "][")]
        [InlineData("", "Incompatible.")]
        [InlineData(new int[] { 1, 2, 3 }, "Incompatible.")]
        [InlineData("dfdkf49824fdfdfjhd", "Two's a pair.")]
        [InlineData("#343473847#", "Two's a pair.")]
        public void FlipEndChars_Works(object input, string expected)
        {
            string actual = sf.FlipEndChars(input);

            Assert.Equal(expected, actual);
        }
    }
}
