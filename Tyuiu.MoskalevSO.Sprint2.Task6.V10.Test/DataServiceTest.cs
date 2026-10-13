using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint2.Task6.V10.Lib;

namespace Tyuiu.MoskalevSO.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 3;
            int n = 1;

            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "28.2.2023";

            Assert.AreEqual(wait, res);
        }
    }
}