using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task0.V12.Lib
{
    public class DataServies : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
                return new bool[]
            {
                x + y == 1570,
                x - y != 620,
                y < x,
                y > x,
                x - y <= 620,
                x + y >= 2000
            };
        } 
    }
}
