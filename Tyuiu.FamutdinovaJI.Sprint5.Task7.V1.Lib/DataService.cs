using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = $@"{Path.GetTempPath()}/OutPutDataFileTask7V1.txt";
            string text = File.ReadAllText(path);
            string[] strings = text.Split(new char[] { ' ', '.' });
            string line = "";
            foreach (string s in strings)
            {
                if (int.TryParse(s, out int num))
                {
                    continue;
                }
                else
                {
                    line += s;
                }
            }
            string res1 = string.Join(" ", strings);
            string res = Regex.Replace(res1, " {2,}", " ");
            File.WriteAllText(savepath, line);
            return savepath;
        }
    }
}
