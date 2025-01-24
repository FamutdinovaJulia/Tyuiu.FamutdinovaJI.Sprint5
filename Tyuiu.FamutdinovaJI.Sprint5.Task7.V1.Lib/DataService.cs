using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = $@"{Path.GetTempPath()}/OutPutDataFileTask7V15.txt";
            string text = File.ReadAllText(path);
            string[] strings = text.Split(new char[] { ' ' });
            for (int i = 0; i < strings.Length; i++)
            {
                Int32.TryParse(strings[i], out int j);
                if (j > 0)
                {
                    strings[i] = ""; 
                }
            }
            string res1 = string.Join(" ", strings);
            string res = Regex.Replace(res1, " {2,}", " ");
            File.WriteAllText(savepath, res);
            return savepath;
        }
    }
}
