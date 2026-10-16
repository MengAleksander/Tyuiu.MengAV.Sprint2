using Tyuiu.MengAV.Sprint2.Task6.V15.Lib;

namespace Tyuiu.MengAV.Sprint2.Task6.V15.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void IsMonday()
        {
            Assert.Equal("понедельник", ds.FindDayName(1));
        }

        [Fact]
        public void IsSunday()
        {
            Assert.Equal("воскресенье", ds.FindDayName(7));
        }

        [Fact]
        public void IsLastMonday()
        {
            Assert.Equal("понедельник", ds.FindDayName(365));
        }
    }
}