using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.ComponentModel.Design;
namespace Tyuiu.KokoulinIV.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20

    {
       

        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                int x = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    x++;
                    if (line == "")
                    {
                        continue;
                    }
                    else
                    {
                        string[] array = line.Split(' ');
                        if (array[0] == "")
                        {
                            resStr += array[2] + " ";
                        }
                        else
                        {
                            resStr += array[1] + " ";
                        }
                        
                    }

                }
                if (resStr[resStr.Length-1] == ' ')
                {
                    resStr = resStr.Substring(0, resStr.Length-1);
                }
            }
            return resStr;
        }
    }
}
