using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task0.V2.Lib
{
    public class DataService: ISprint5Task0V2
    {
    public string SaveToFileTextData(int x)
        {
            double e = 2.718;
            string path = Path.GetTempFileName();
            double z = Math.Pow(e, x) / x;
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
