using Tyuiu.KokoulinIV.Sprint6.Task5.V7.Lib;
using System.IO;
namespace Tyuiu.KokoulinIV.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint6\\Tyuiu.KokoulinIV.Sprint6.Task5.V7\\Test.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wail = { 6, 7, 8 };
            Assert.AreEqual(res.Length, wail.Length);
            Assert.AreEqual(res[1], wail[1]);
        }
    }
}