using Tyuiu.MengAV.Sprint2.Task3.V12.Lib;

namespace Tyuiu.MengAV.Sprint2.Task3.V12.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void XIsZero()
        {
            Assert.Equal(1.540, ds.Calculate(0));
        }

        [Fact]
        public void XIsMinusOne()
        {
            Assert.Equal(12.000, ds.Calculate(-1));
        }

        [Fact]
        public void XIsMinusSixteen()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => ds.Calculate(-16));
        }
    }
}