using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double Product = 1.0;

            for (int X = startValue; X <= stopValue; X++)
            {
                if (X == 0)
                    continue;

                double Y = X / (Math.Cos(X) - X) + 2.5;
                Product *= Y;
            }

            return Product;
        }

    }
}