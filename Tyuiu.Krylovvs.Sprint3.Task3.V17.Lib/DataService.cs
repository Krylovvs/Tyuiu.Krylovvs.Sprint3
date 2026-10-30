using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.Krylovvs.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string Digits = "";

            foreach (char Character in value)
            {
                if (Character >= '0' && Character <= '9')
                {
                    Digits += Character;
                }
            }

            return Digits.Length > 0 ? int.Parse(Digits) : 0;
        }

    }
}