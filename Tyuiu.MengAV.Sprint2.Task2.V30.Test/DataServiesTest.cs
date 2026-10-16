using Tyuiu.MengAV.Sprint2.Task2.V30.Lib;

namespace Tyuiu.MengAV.Sprint2.Task2.V30.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void InsideLeft()
        {
            Assert.True(ds.CheckDotInShadedArea(3, 3));
        }

        [Fact]
        public void InsideMiddle()
        {
            Assert.True(ds.CheckDotInShadedArea(7, 7));
        }

        [Fact]
        public void Outside()
        {
            Assert.False(ds.CheckDotInShadedArea(1, 1));
        }
    }
}