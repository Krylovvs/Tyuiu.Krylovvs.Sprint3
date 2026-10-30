using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double Res = 1.0;
            int Back = startValue;

            while (Back <= stopValue)
            {
                Res *= Math.Cos(0.1) + 1.0 / (Back * Back);
                Back++;
            }

            return Res;
        }

    }
}