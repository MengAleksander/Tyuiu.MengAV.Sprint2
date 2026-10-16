using Tyuiu.MengAV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.MengAV.Sprint2.Task5.V13.Test
{
    public class UnitTest1
    {
        DataServies ds = new DataServies();
        [Fact]
        public void InLeapFebruary()
        {
            Assert.Equal("01.03.2026", ds.FindDateOfNextDay(2026, 2, 29));
        }

        [Fact]
        public void AtYearEnd()
        {
            Assert.Equal("01.01.2027", ds.FindDateOfNextDay(2026, 12, 31));
        }

        [Fact]
        public void WhenDayIsInvalid()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => ds.FindDateOfNextDay(2026, 4, 31));
        }
    }
}