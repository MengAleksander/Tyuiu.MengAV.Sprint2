using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task6.V15.Lib
{
    public class DataServies : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
                throw new ArgumentOutOfRangeException(
                    nameof(k), "Число k должно быть от 1 до 365.");

            return ((k - 1) % 7) switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "суббота",
                6 => "воскресенье",
                _ => throw new InvalidOperationException()
            };
        }
    }
}
