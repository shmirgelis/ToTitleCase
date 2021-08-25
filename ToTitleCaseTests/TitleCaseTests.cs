using ConvertToTitleCase;
using System;
using Xunit;

namespace ToTitleCaseTests
{
    public class TitleCaseTests
    {
        [Fact]
        public void String_is_white_space()
        {
            //Arrange
            string givenString = " ";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = " ";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_is_double_white_space()
        {
            //Arrange
            string givenString = "  ";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "  ";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_is_single_letter()
        {
            //Arrange
            string givenString = "m";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "M";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_is_single_word()
        {
            //Arrange
            string givenString = "telia";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "Telia";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_has_white_space_in_front()
        {
            //Arrange
            string givenString = " telia";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = " Telia";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_has_white_space_at_the_end()
        {
            //Arrange
            string givenString = "telia ";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "Telia ";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_with_single_white_space_between_words()
        {
            //Arrange
            string givenString = "life is like a box of chocolates";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "Life Is Like A Box Of Chocolates";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }

        [Fact]
        public void String_has_double_white_spaces_between_words()
        {
            //Arrange
            string givenString = "life  is  like  a  box  of  chocolates";
            //Act
            string titleCaseString = givenString.ToTitleCase();
            string changedString = "Life  Is  Like  A  Box  Of  Chocolates";
            //Assert
            Assert.Equal(changedString, titleCaseString);
        }
    }

}
