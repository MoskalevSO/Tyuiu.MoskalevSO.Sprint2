using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint2.Task5.V7.Lib;

namespace Tyuiu.MoskalevSO.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMonthName()
        {
            DataService ds = new DataService();
            int n = 14;
            string res = ds.FindMonthName(n);
            string wait = "март";

            Assert.AreEqual(wait, res);
        }
    }
}