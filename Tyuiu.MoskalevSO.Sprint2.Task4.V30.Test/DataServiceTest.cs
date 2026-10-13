using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint2.Task4.V30.Lib;

namespace Tyuiu.MoskalevSO.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 2;
            double res = ds.Calculate(x, y);
            double wait = 41.531;

            Assert.AreEqual(wait, res);
        }
    }
}