using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint2.Task5.V7.Lib;

namespace Tyuiu.MoskalevSO.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int n = 1990;
            int days = 2;
            string res = ds.FindMonthName(n, days);
            string wait = "март";
            Assert.AreEqual(wait, res);
        }
    }
}