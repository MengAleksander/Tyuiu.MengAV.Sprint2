using Tyuiu.MengAV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.MengAV.Sprint2.Task7.V7.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void Test1()
        {
            Assert.True(ds.CheckDotInShadedArea(0, 1));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(ds.CheckDotInShadedArea(-1, -0.5));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(ds.CheckDotInShadedArea(0, 3));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(ds.CheckDotInShadedArea(1, -1));
        }
    }
}