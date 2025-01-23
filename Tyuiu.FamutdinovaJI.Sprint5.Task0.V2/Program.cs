﻿using Tyuiu.FamutdinovaJI.Sprint5.Task0.V2.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
           
            int x = 3;
            Console.WriteLine("* 3начение переменной Х: " + x );

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            StreamReader sr = new StreamReader(res);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine();
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
