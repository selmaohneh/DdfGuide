using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class DdfGuideTests
    {
        [TestMethod]
        public void CreateNewDdfGuide()
        {
            var systemUnderTest = new Core.DdfGuide();

            Assert.IsNotNull(systemUnderTest);
        }
    }
}
