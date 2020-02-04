using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange portion -- staging the data and variables you want to test
            var book = new Book("");
            book.Addgrade(89.1);
            book.Addgrade(90.5);
            book.Addgrade(77.3);

            // act portion -- store the calculations or procedures you want to test
            var result = book.GetStats();

            // assert portion -- assert something about the value that was computed
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
