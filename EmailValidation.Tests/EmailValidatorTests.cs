using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailValidation;
using Xunit;

namespace EmailValidation.Tests
{
    public class EmailValidatorTests
    {
        EmailValidator ev = new EmailValidator();

        [Theory]
        [InlineData("@edabit.com", false)]
        [InlineData("@edabit", false)]
        [InlineData("matt@edabit.com", true)]
        [InlineData("", false)]
        [InlineData("hello.gmail@com", false)]
        [InlineData("bill.gates@microsoft.com", true)]
        [InlineData("hello@email", false)]
        [InlineData("%^%$#%^%", false)]
        [InlineData("www.email.com", false)]
        [InlineData("email", false)]
        public void ValidateEmail_ShouldWork(string email, Boolean expected)
        {
            Boolean actual = ev.ValidateEmail(email);

            Assert.True(expected == actual);
        }
    }
}
