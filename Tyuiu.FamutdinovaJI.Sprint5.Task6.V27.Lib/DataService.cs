using Microsoft.VisualBasic;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            foreach (string s in strings)
            {
                if (int.TryParse(s, out int num))
                {
                    
                    if ((num > 99) && (num < 1000))
                    {
                        count += 1;
                    }
                    
                }
            }   
             return count;
        }
    }
}
