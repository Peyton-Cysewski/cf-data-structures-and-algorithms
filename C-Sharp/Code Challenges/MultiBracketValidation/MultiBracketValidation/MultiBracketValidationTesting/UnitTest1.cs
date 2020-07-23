using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsTrueWhenBalanced()
        {
            // Assign
            string test = "{[()]}";
            // Act
            bool result = ValidateMultiBrackets(test);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseWhenUnbalanced()
        {
            // Assign
            string test = "{[()}";
            // Act
            bool result = ValidateMultiBrackets(test);
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueWithEmptyString()
        {
            // Assign
            string test = "";
            // Act
            bool result = ValidateMultiBrackets(test);
            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("{}", true)]
        [InlineData("[]", true)]
        [InlineData("{}(){}", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("[({}]", false)]
        [InlineData("(](", false)]
        [InlineData("{(})", false)]
        [InlineData("(////)", true)]
        [InlineData(@"(/|\|/|\|/|\)", true)]
        [InlineData(@"\\\\\\\\\", true)]
        [InlineData(@"}", false)]
        public void ReturnsCorrectForAllCases(string input, bool expected)
        {
            bool actual = ValidateMultiBrackets(input);
            Assert.Equal(expected, actual);
        }
    }
}
