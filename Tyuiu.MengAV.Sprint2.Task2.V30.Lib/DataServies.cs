using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task2.V30.Lib
{
    public class DataServies : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            return
            (y == 3 && (x >= 3 && x <= 5 || x >= 9 && x <= 12)) ||

            (y == 4 && (x >= 2 && x <= 5 || x >= 9 && x <= 12)) ||

            (y == 5 && x >= 2 && x <= 12) ||

            (y == 6 && x >= 2 && x <= 13) ||

            (y == 7 && x >= 3 && x <= 13) ||

            (x == 6 && y >= 8 && y <= 10) ||

            (y == 11 && x >= 3 && x <= 12) ||

            (y == 12 && x >= 7 && x <= 10);
        }
    }
}
