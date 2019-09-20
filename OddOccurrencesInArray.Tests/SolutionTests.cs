using System;
using Xunit;

namespace OddOccurrencesInArray.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 9, 3, 9, 3,9,7,9 },7)]
        [InlineData(new[] { 1, 1, 1, 1, 1, 1, 9 }, 9)]
        [InlineData(new[] { -1,0,0,0,0,0,0,0,0,0,0},-1)]
        public void solution_Returns_Expected(int[] array, int result)
        {
            Solution sln = new Solution();
            var res = sln.solution(array);
            Assert.Equal(result, res);
        }
    }
}
