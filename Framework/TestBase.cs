using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Browser.Initialize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }

        [ClassCleanup]
        public void ClassCleanUp()
        {
            Browser.Close();
        }
    }
}
