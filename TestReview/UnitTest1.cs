using System;
using Xunit;
using Review;

namespace TestReview
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 2", 0)]
        [InlineData("1 2 3 4", 6)]
        [InlineData("-1 2 3", -6)]
        [InlineData("-1 2 0", 0)]
        public void TestChallenge1(string input, int expected)
        {
            int actual = Program.GetProduct(input);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void testChallenge2(int[] arr, int expected)
        {


            int actual = Program.GetAverage(arr, arr.Length);


            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 55, 108, 4 }, 123)]
        [InlineData(new int[] { -5, -1, -3 }, -1)]
        [InlineData(new int[] { -8, -150, -7, 5 }, 5)]
        [InlineData(new int[] { 2, 2, 2, 2 }, 2)]
        public void testChallenge5(int[] arr, int expected)
        {

            int actual = Program.GetMaximum(arr);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 4 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1)]
        public void getPopularElementTests(int[] arr, int expected)
        {
            int actual = Program.getduplicates(arr);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("my name is sultan kanaan", new string[] { "\" my : 2 \", ", "\" name : 4 \", ", "\" is : 2 \", ", "\" sultan : 6 \", ", "\" kanaan : 6 \", " })]
        [InlineData("my jop is programing", new string[] { "\" my : 2 \", ", "\" jop : 3 \", ", "\" is : 2 \", ", "\" programing : 10 \", " })]

        public void testChallenge9(string input, string[] expected)
        {

            string[] actual = Program.getword(input);
            Assert.Equal(expected,actual);
        }
    }
}
