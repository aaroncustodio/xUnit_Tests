using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Switcharoo;

namespace Switcharoo.Tests
{
    public class SwitchLogicTests
    {
        SwitchLogic sl = new SwitchLogic();

        #region LenBelowTwo
        [Theory]
        [InlineData("amazing", false)]
        [InlineData("ab", false)]
        [InlineData(".", true)]
        public void LenBelowTwo_Works(string input, Boolean expected)
        {
            Boolean actual = sl.LenBelowTwo(input);

            Assert.True(expected == actual);
        }
        #endregion

        #region IsString
        [Theory]
        //[InlineData(arr[0], true)]
        [InlineData("I am a string.", true)]
        [InlineData(34, false)]
        public void IsString_Works(object input, Boolean expected)
        {
            Boolean actual = sl.IsString(input);

            Assert.True(expected == actual);
        }
        #endregion

        #region FirstLastIsSame
        [Theory]
        [InlineData("I am a stringI", true)]
        [InlineData("22", true)]
        [InlineData("a na bA", false)]
        public void FirstLastIsSame_Works(string input, Boolean expected)
        {
            Boolean actual = sl.FirstLastIsSame(input);

            Assert.True(expected == actual);
        }
        #endregion

        #region SwitchFirstLast
        [Theory]
        [InlineData("I am a string.", ". am a stringI")]
        [InlineData("Bass", "sasB")]
        [InlineData("a na bA", "A na ba")]
        public void SwitchFirstLast_Works(string input, string expected)
        {
            string actual = sl.SwitchFirstLast(input);

            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
