using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (stopValue < startValue)
                return Array.Empty<double>();

            double[] Values = new double[stopValue - startValue + 1];

            for (int X = startValue; X <= stopValue; X++)
            {
                double Denominator = Math.Cos(X) - 2 * X;

                if (Denominator == 0)
                {
                    Values[X - startValue] = 0;
                }
                else
                {
                    double Result = (2 * X - 3) / Denominator + 5 * X - 6;
                    Values[X - startValue] = Math.Round(Result, 2);
                }
            }

            return Values;
        }

    }
}