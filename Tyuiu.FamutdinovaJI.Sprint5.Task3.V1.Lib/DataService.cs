using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double res = (Math.Pow(x, 3) - 8) / (2 * x * x);
            res = Math.Round(res, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
