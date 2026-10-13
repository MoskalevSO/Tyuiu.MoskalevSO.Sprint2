using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevSO.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x / y == 29;
            res[1] = x % y != 130;
            res[2] = y + 100 < x;
            res[3] = y + 100 > x;
            res[4] = y * 2 <= x;
            res[5] = y * 2 >= x;

            return res;
        }
    }
}