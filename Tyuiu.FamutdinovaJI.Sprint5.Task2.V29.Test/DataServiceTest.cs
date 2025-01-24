using Tyuiu.FamutdinovaJI.Sprint5.Task2.V29.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task2.V29.Test
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
    }
}