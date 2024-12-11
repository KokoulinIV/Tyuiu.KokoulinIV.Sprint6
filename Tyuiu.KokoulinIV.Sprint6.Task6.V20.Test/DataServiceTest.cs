
using System.IO;

namespace Tyuiu.KokoulinIV.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr += " " + line;
                    }
                }
                string[] array = resStr.Split(" ");
                resStr = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        resStr += array[i] + " ";
                    }
                }

            }
            return resStr;
        }
    }
}