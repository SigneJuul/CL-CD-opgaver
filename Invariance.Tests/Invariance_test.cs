using Xunit;
using ValidateTheNameModelBinding.Models;

namespace Invariance.Tests
{
    public class FirstName_test
    {
        [Theory]
        [InlineData("meme", "meme")]
        [InlineData("Signe", "dsjfkjfd")]
        [InlineData("sfsdffsfd", "sfffdss")]
        public void FirstName_Lenght_No_Exception(string firstName, string lastName)
        {
            //No exception when lenght fit
            var person = new Person(firstName, lastName);

        }

        [Theory]
        [InlineData("medhas", "masse")]
        [InlineData("meme", "meme")]
        public void FirstName_Character_No_Exception(string firstName, string lastName)
        {
            var person = new Person(firstName, lastName);
        }

        [Theory]
        [InlineData("me", "me")]
        [InlineData("", "")]
        [InlineData("Signedddddddddddddddddddddd", "dsjfkjfd")]
        public void FirstName_Lenght_Exception(string firstName, string lastName)
        {
            //No exception when lenght fit
            var person = new Person(firstName, lastName);

        }

        [Theory]
        [InlineData("hej22", "dsjfkjfd")]
        [InlineData("sf!!fsfd", "sfffdss")]
        public void FirstName_Character_Exception(string firstName, string lastName)
        {
            var person = new Person(firstName, lastName);
        }

        [Theory]
        [InlineData("", "")]
        public void FirstName_Null_Exception(string firstName, string lastName)
        {
            //No exception when lenght fit
            var person = new Person(firstName, lastName);

        }
    }
}