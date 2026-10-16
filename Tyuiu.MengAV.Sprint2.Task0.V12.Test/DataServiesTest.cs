using Tyuiu.MengAV.Sprint2.Task0.V12.Lib;

namespace Tyuiu.MengAV.Sprint2.Task0.V12.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void ExpectedBool()
        {
            bool[] expect = { true, false, true, false, true, false };

            bool[] actual = ds.GetCompareOperations(1095, 475);

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void SixResults()
        {
            bool[] actual = ds.GetCompareOperations(1095, 475);

            Assert.Equal(6, actual.Length);
        } 
    }
}