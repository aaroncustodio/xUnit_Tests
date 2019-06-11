using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailValidation;
using Xunit;


namespace EmailValidation.Tests
{
    public class ValidationConditionTests
    {
        ValidationCondition vc = new ValidationCondition();

        #region ContainsAtDot
        [Theory]
        [InlineData("user@email.com")]
        [InlineData("@.")]
        public void ContainsAtDot_ShouldWork(string email)
        {
            Assert.True(vc.ContainsAtDot(email));
        }

        [Theory]
        [InlineData("email.com")]
        [InlineData("yahoo@gmail")]
        public void ContainsAtDot_ShouldFail(string email)
        {
            Assert.False(vc.ContainsAtDot(email));
        }
        #endregion

        #region CharBeforeAt
        [Theory]
        [InlineData("a@rocketmail.com")]
        [InlineData("@sample@.com")]
        public void CharBeforeAt_ShouldWork(string email)
        {
            Assert.True(vc.CharBeforeAt(email));
        }

        [Theory]
        [InlineData("@rocketmail.com")]
        [InlineData("   @haha")]
        [InlineData(" .     @haha")]
        public void CharBeforeAt_ShouldFail(string email)
        {
            Assert.False(vc.CharBeforeAt(email));
        }
        #endregion

        #region AtDotInProperPlace
        [Theory]
        [InlineData("@rocketmail.com")]
        [InlineData("   @haha.ph")]
        [InlineData("aaa@.rocketmail@com.ph")]
        public void AtDotInProperPlace_ShouldWork(string email)
        {
            Assert.True(vc.AtDotInProperPlace(email));
        }

        [Theory]
        [InlineData(".rocketmail@com")]
        [InlineData("aaa@.rocketmail@com")]
        public void AtDotInProperPlace_ShouldFail(string email)
        {
            Assert.False(vc.AtDotInProperPlace(email));
        }
        #endregion
    }
}
