namespace CCDemo.Data.Tests.Unit
{
    public class PasswordValidatorTests
    {
        private readonly PasswordValidator _sut = new();

        [Fact]
        public void HasUpperCase_WhenContainsUpperCase()
        {
            string password = "Password";

            bool result = _sut.HasUpperCase(password);

            Assert.True(result);
        }
        //twee tests

        [Fact]
        public void HasLowerCase_WhenContainsLowerCase()
        {
            string password = "PASSWORDa";

            bool result = _sut.HasLowerCase(password);

            Assert.True(result);
        }

        [Fact]
        public void HasDigit_WhenContainsDigit()
        {
            string password = "Password1";

            bool result = _sut.HasDigit(password);

            Assert.True(result);
        }

        [Fact]
        public void HasSpecialCharacter_WhenContainsSpecialCharacter()
        {
            string password = "Password!";

            bool result = _sut.HasSpecialCharacter(password);

            Assert.True(result);
        }
    }
}
