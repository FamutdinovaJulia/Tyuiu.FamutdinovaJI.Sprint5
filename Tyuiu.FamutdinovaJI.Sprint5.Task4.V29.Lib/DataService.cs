using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            var fmt = new NumberFormatInfo();
            fmt.NegativeSign = "−";
            var x = double.Parse(strx, fmt);
            double res = (x / (2 * x)) + Math.Sin(x * x);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
