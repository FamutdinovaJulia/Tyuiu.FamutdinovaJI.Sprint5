using Tyuiu.FamutdinovaJI.Sprint5.Task2.V29.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = { { 9, 2, 5 }, { 3, 2, 4 }, { 2, 8, 8 } };

            Console.WriteLine("*  = " + matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);
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
