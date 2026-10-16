using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MengAV.Sprint2.Task1.V16.Lib
{
    public class DataServies : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (a == 145) | (b == 0),
                (a != b) & (c == 144),
                (a < b) || (c < d),   
                (a > b) && (c > d),   
                !(c <= d),            
                (a >= b) ^ (a == b)   
            };
        }
    }
}
