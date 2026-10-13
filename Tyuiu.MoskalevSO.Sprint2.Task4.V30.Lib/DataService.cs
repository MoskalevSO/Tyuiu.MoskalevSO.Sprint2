using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevSO.Sprint2.Task4.V30.Lib
{
    public class DataService : ISprint2Task4V30
    {
        public double Calculate(double x, double y)
        {
            double res = x * 2 > y
                ? Math.Pow(6 + 4.0 / Math.Pow(x, 2), y)
                : y + 2.0 / Math.Pow(x, 2);

            res = Math.Round(res, 3);
            return res;
        }
    }
}