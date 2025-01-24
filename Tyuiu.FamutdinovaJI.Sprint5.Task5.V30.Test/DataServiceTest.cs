using Tyuiu.FamutdinovaJI.Sprint5.Task5.V30.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            Assert.IsTrue(fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double max = -100;
            string text = "8 20 2 4.45 19.58 10 1 -1 4.29 -7.47 -6.91 0 20 5.24 -7.65 -1.97 6.64 3.67 6 13.61";
            string[] strings = text.Split(" ");
            double res = 1;
            foreach (string s in strings)
            {
                if (Double.TryParse(s, out double number) && (number % 1 == 0))
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            continue;
                        }
                    }
                    if (max < number)
                    {
                        max = number;
                    }
                }
            }
            Assert.AreEqual(Math.Round(max, 3), 20);
        }
    }
}