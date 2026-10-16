using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task3.V12.Lib
{
    public class DataServies : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double result; 

            if (x > 1)
            {
                result = x + Math.Pow(x + 1, 3) / (x - 1);
            }
            else if (x == 0)
            {
                result = 1 + Math.Cos(Math.Sqrt(x + 1));
            }
            else if (x > -16 && x < 2)
            {
                result = 7 + 5 / Math.Pow(x, 2);
            }
            else if (x < -16)
            {
                result = x + 10 * x - 1 / x;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(x),
                    "Для данного числа значение функции не задано.");
            }

            return Math.Round(result, 3);
        }
    }
}
