using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double Res = 0.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                Res += (Math.Pow(value, k) + 0.5) * Math.Cos(k);
            }

            return Res;
        }

    }
}