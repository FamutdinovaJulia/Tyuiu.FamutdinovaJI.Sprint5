using Tyuiu.FamutdinovaJI.Sprint5.Task0.V2.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            StreamReader sr = new StreamReader(res);
            Console.WriteLine(res);
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
