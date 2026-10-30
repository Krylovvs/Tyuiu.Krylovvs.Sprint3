using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int Sum = 0;

            for (int Number = startValue; Number <= stopValue; Number++)
            {
                for (int Divisor = 9; Divisor <= Number; Divisor++)
                {
                    if (Number % Divisor == 0)
                    {
                        Sum += Divisor;
                    }
                }
            }

            return Sum;
        }

    }
}