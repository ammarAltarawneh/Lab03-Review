using Lab03_Review;

namespace ReviewChallengeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Product3Num()
        {
            [Theory]
            [InlineData("3 4 5", 60)] //Input a string of numbers and it returns a product of all numbers
            [InlineData("2 3 2 8", 12)] //Input more than 3 numbers
            [InlineData("4 5", 0)] //Input of less than 3 numbers
            [InlineData("-2 -3 -4", -24)] //Can it handle negative numbers
            [InlineData("3 5 k", 15)]   //Can it handle not numbers elements
            void Probuct3Num_Test(string input, int expected)
            {
                int result = Program.Product3Num(input);

                Assert.Equal(expected, result);
            }
        }
    }
}