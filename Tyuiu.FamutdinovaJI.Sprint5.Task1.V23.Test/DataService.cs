using Tyuiu.FamutdinovaJI.Sprint5.Task1.V23.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint5.Task1.V23.Test
{
    [TestClass]
    public class DataService
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