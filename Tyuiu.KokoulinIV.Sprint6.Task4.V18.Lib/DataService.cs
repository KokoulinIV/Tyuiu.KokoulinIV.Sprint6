using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KokoulinIV.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int x = startValue;
            for (int i = 0; i < len; i++)
            {
                double y = ((2 * x - 3) / (Math.Cos(x) + x)) + 5;
                y = Math.Round(y,2);
                if ( (Math.Cos(x)+x)==0)
                {
                    y = 0;
                }
                res[i] = y;
                x++;
            }
            return res;
        }
    }
}
