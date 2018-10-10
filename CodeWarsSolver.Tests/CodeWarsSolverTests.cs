using System;
using Xunit;
using CWKataSolver;

namespace CWSolver.Tests
{
    public class CodeWarsSolverTests
    {
        // Level 8 kata https://www.codewars.com/kata/57356c55867b9b7a60000bd7
        [Theory]
        [InlineData('+', 4, 7, 11)]
        [InlineData('-', 15, 18, -3)]
        [InlineData('*', 5, 5, 25)]
        [InlineData('/', 49, 7, 7)]
        public void BasicMathOperation(char operation, double value1, double value2, double expected)
        {
            // Arrange
            var cwSolver = new CodeWarsSolver();

            // Act
            double actual = cwSolver.basicOp(operation, value1, value2);

            // Assert
            Assert.Equal(actual, expected);
        }

        // Level 8 kata https://www.codewars.com/kata/55ccdf1512938ce3ac000056
        [Theory]
        [InlineData("Can I have some change? Tree Fiddy will do", true)]
        [InlineData("Good sir, might I borrow tree fiddy in change?", true)]
        [InlineData("Hey, can I borrow four fourty?", false)]
        [InlineData("Oi! You got $3.50 on ye!?", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void TreeFiddy(string sentence, bool expected)
        {
            // Arrange
            CodeWarsSolver kata = new CodeWarsSolver();

            // Act
            bool actual = kata.IsLochNessMonster(sentence);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Level 6 kata https://www.codewars.com/kata/is-a-number-prime/train/csharp
        [Theory]
        [InlineData(7, true)]
        [InlineData(9, false)]
        [InlineData(2, true)]
        [InlineData(197, true)]
        [InlineData(0, false)]
        public void IsPrime(int n, bool expected)
        {
            // Arrange
            CodeWarsSolver doIt = new CodeWarsSolver();

            // Act
            bool actual = doIt.IsPrime(n);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Level 6 kata https://www.codewars.com/kata/514b92a657cdc65150000006
        [Theory]
        [InlineData(10, 23)]
        [InlineData(21, 113)]
        [InlineData(0, 0)]
        [InlineData(5, 8)]
        public void Solution(int value, int expected)
        {
            // Arrange
            CodeWarsSolver solution = new CodeWarsSolver();

            // Act
            int actual = solution.Solution(value);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Level 6 kata https://www.codewars.com/kata/array-dot-diff

        [Theory]
        [InlineData(new int[] { 0, 1, 2 }, new int[] { 0, 1 }, new int[]{ 2 })]
        [InlineData(new int[] { 9, 654, 21, 0, 5 }, new int[] { 9, 21, 0 }, new int[] { 654, 5 })]
        [InlineData(new int[] { 9, 8, 7, 6 }, new int[] { 8, 7, 6 }, new int[] { 9 })]
        [InlineData(null, null, null)]
        public void ArrayDiff(int[] a, int[] b, int[] expected)
        {
            // Arrange
            CodeWarsSolver diff = new CodeWarsSolver();

            // Act
            int[] actual = diff.ArrayDiff(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Level 5 kata https://www.codewars.com/kata/latest/my-languages
        [Theory]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 1, "Sheldon")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 6, "Sheldon")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 4, "Rajesh")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 8, "Leonard")]

        public void WhoIsNext(string[] values, long n, string expected)
        {
            // Arrange
            CodeWarsSolver solver = new CodeWarsSolver();

            // Act
            string actual = solver.WhoIsNext(values, n);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
