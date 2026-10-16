using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task5.V13.Lib
{
    public class DataServies : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            return m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => n switch
                    {
                        >= 1 and < 31 => $"{n + 1:D2}.{m:D2}.{g}",

                        31 when m < 12 => $"01.{m + 1:D2}.{g}",

                        31 => $"01.01.{g + 1}",

                        _ => throw new ArgumentOutOfRangeException(nameof(n))
                    },

                4 or 6 or 9 or 11 => n switch
                    {
                        >= 1 and < 30 => $"{n + 1:D2}.{m:D2}.{g}",

                        30 => $"01.{m + 1:D2}.{g}",

                        _ => throw new ArgumentOutOfRangeException(nameof(n))
                    },

                2 => n switch
                    {
                        >= 1 and < 29 => $"{n + 1:D2}.02.{g}",

                        29 => $"01.03.{g}",

                        _ => throw new ArgumentOutOfRangeException(nameof(n))
                    },

                _ => throw new ArgumentOutOfRangeException(nameof(m))
            };
        }
    }
}
