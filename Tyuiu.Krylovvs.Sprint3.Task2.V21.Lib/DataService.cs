using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double Value, int StartValue, int StopValue)
        {
            double Sum = 0.0;
            int K = StartValue;

            do
            {
                double Denominator = Math.Sin(K + 2.0 * Math.Pow(Value, K));

                Sum += Math.Pow(1.0 / Denominator, K);
                K++;
            }
            while (K <= StopValue);

            return Sum;
        }

    }
}