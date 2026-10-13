using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevSO.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevG = g;
            int prevM = m;
            int prevN = n;

            if (n > 1)
            {
                prevN = n - 1;
            }
            else
            {
                (prevG, prevM, prevN) = m switch
                {
                    1 => (g - 1, 12, 31),
                    3 => (g, 2, 28),
                    5 or 7 or 8 or 10 or 12 => (g, m - 1, 30),
                    _ => (g, m - 1, 31)
                };
            }

            // Добавили формат :D2, чтобы получить ведущие нули (например, 07.09.2023)
            return $"{prevN:D2}.{prevM:D2}.{prevG}";
        }
    }
}