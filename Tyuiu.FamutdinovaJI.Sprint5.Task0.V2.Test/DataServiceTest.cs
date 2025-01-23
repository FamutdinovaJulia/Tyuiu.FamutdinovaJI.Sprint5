using Tyuiu.FamutdinovaJI.Sprint5.Task0.V2.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task0.V2.Test
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