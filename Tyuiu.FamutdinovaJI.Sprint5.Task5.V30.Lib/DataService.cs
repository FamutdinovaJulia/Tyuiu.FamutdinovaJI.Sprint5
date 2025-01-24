using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            double max = -100;
            foreach (string s in strings)
            {
                if (Double.TryParse(s, out double number) && (number % 1 == 0))
                {
                    int count = 0;
                    for (int i = 2; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                    if ((max < number) && (count == 1))
                    {
                        max = number;
                    }

                }
            }
            return Math.Round(max, 3);
        }
    }
}
