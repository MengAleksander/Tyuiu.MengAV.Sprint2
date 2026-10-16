using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task4.V11.Lib
{
    public class DataServies : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            double res;

            if (x - 20 * 2 < y / 4)
            {
                res = Math.Pow(3 + 8 / Math.Pow(x, 2), y);
            }
            else
            {
                res = y - Math.Pow((x + 1) / (y + 2), x);
            }

            if (double.IsNaN(res) || double.IsInfinity(res))
                throw new ArgumentException(
                    "Для заданных x и y результат не определён.");

            return Math.Round(res, 3);
        }
    }
}
