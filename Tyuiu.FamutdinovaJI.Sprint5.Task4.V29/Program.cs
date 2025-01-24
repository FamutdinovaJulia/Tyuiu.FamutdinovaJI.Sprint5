using Tyuiu.FamutdinovaJI.Sprint5.Task4.V29.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            string y = "4";
            File.AppendAllText(path, y);
            DataService ds = new DataService();
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
a