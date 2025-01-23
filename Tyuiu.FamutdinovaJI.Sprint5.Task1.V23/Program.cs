using Tyuiu.FamutdinovaJI.Sprint5.Task1.V23.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            Console.WriteLine("* Диапазон = [" + x + "; " + y + "]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x, y);
            StreamReader sr = new StreamReader(res);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine();
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }


        }
    }
}
