using NUnit.Framework;
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
            // Assert
            Assert.True(expected.SequenceEqual(Sort(data)));
        }

        private IEnumerable<int> Sort(int[] data)
        {
            for (int step = data.Length / 2; step > 0; step /= 2)
            {
                for (int i = 1; i < data.Length; i++)
                {
                    int current = data[i];
                    int position = step;
                    for (; position < data.Length; position += step)
                    {
                        if (data[position] <current)
                        {
                            data[position] = data[position];
                        }
                    }
                    data[position] = current;
                }
            }
            return data;
        }
    }
}