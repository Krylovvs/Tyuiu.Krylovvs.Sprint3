using tyuiu.cources.programming.interfaces;
//using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib
{
    public class DataService : BeatIt
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