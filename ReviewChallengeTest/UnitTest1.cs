using Lab03_Review;

namespace ReviewChallengeTest
{
    public class UnitTest1
    {
            
            [Theory]
            [InlineData("3 4 5", 60)] //Input a string of numbers and it returns a product of all numbers
            [InlineData("2 3 2 8", 12)] //Input more than 3 numbers
            [InlineData("4 5", 0)] //Input of less than 3 numbers
            [InlineData("-2 -3 -4", -24)] //Can it handle negative numbers
            [InlineData("3 5 k", 15)]   //Can it handle not numbers elements
            public void Probuct3Num_Test(string input, int expected)
            {
                int result = Program.Product3Num(input);

                Assert.Equal(expected, result);
            }

        

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new[] { 8, 8, 8, 8, 8, 8 }, 8)]
        [InlineData(new[] { 3, 4, 5, 6, 7, 8 }, 3)]
        [InlineData(new[] { 12, 1, 5, 5, 10, 9, 9, 1 }, 1)]
        public void MostAppearsNumberInArray_Test(int[] numbers, int expected)
        {
            int MostAppearsNumber = Program.MostAppearsNumberInArray(numbers);

            Assert.Equal(expected, MostAppearsNumber);
        }

        [Theory]
        [InlineData(new[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 555)]
        [InlineData(new[] { 3, 1, -2, 2, 3, 5, -3, -7 }, 5)] //Negative numbers
        [InlineData(new[] { 8, 8, 8, 8, 8, 8 }, 8)] //All values are the same
        public void MaxValueInArrayValidAndNegatives_Test(int[] numbers, int expectedMaxValue)
        {

            int maxValue = Program.MaxValueInArray(numbers);

            Assert.Equal(expectedMaxValue, maxValue);
        }
    }
}