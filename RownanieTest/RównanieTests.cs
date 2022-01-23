using Rownanie;
using System;
using Xunit;

namespace RownanieTest
{
    public class RównanieTests
    {
        [Theory]
        [InlineData(-1,-11,12,1,-12)]
        [InlineData(1, 5, 6, -3, -2)]
        [InlineData(8, 5, 6, double.NaN, double.NaN)]
        [InlineData(1, 0, 1, double.NaN, double.NaN)]
        [InlineData(1, 2, 1, -1, -1)]
        [InlineData(4, 4, 1, -0.5, -0.5)]
        public void Test1(double a, double b, double c, double x1, double x2)
        {
            Równanie r = new Równanie();

            (double, double) mz = r.Mzerowe(a, b, c);

            Assert.Equal(x1, mz.Item1,1);
            Assert.Equal(x2, mz.Item2, 1);
        }
    }
}
