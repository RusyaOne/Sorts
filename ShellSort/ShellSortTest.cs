using NUnit.Framework;
using Sorts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShellSort
{
    public class ShellSortTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            // Arrange
            var data = new int[] { 35, 33, 42, 10, 14, 19, 27, 44 };
            var expected = new List<int> { 10, 14, 19, 27, 33, 35, 42, 44 };
            // Act
            var shellSort = new ShellSort();
            // Assert
            Assert.True(expected.SequenceEqual(shellSort.Sort(data)));
        }
    }
}