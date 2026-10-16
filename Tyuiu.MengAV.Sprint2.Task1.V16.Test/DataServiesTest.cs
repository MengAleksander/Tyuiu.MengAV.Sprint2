using Tyuiu.MengAV.Sprint2.Task1.V16.Lib;

namespace Tyuiu.MengAV.Sprint2.Task1.V16.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void ExpectedBool()
        {
            bool[] expect = { true, true, true, false, true, false };

            bool[] actual = ds.GetLogicOperations(145, 716, 144, 137);

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void SixResults()
        {
            bool[] actual = ds.GetLogicOperations(145, 716, 144, 137);

            Assert.Equal(6, actual.Length);
        }
    }
}