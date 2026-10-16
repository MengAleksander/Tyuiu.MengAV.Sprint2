using Tyuiu.MengAV.Sprint2.Task4.V11.Lib;

namespace Tyuiu.MengAV.Sprint2.Task4.V11.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void IsTrue()
        {
            Assert.Equal(14641.000, ds.Calculate(1, 4));
        }

        [Fact]
        public void IsFalse()
        {
            Assert.Equal(81.964, ds.Calculate(30, 4));
        }

        [Fact]
        public void ZeroX()
        {
            Assert.Throws<ArgumentException>(
                () => ds.Calculate(0, 4));
        }
    }
}