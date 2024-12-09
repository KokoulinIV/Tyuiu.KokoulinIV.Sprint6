using Tyuiu.KokoulinIV.Sprint6.Task4.V18.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 0;
            int b = 1;
            double[] wail = { 2, 4.35 };
            double[] res = ds.GetMassFunction(a, b);
            CollectionAssert.AreEqual(wail, res);
        }
    }
}