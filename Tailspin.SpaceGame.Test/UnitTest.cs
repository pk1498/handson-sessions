namespace Tailspin.SpaceGame.Test
{
    public class UnitTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(10, 20, 30)]
        [InlineData(-10,10,0)]
        public void BestTest1(int a, int b, int c)
        {
            Assert.Equal(c,a+b);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(10, 20, 30)]
        [InlineData(-10, 10, 0)]
        public void BestTest2(int a, int b, int c)
        {
            Assert.Equal(c, a + b);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(10, 20, 30)]
        [InlineData(-10, 10, 0)]
        public void BestTest3(int a, int b, int c)
        {
            Assert.Equal(c, a + b);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(10, 20, 30)]
        [InlineData(-10, 10, 0)]
        public void BestTest4(int a, int b, int c)
        {
            Assert.Equal(c, a + b);
        }
    }
}