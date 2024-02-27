using DemoApi.Models;

namespace DemoTests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ExampleTestSuccess()
        {
            Item i = new()
            {
                Name = "My dad"
            };
            Assert.AreEqual("My dad", i.Name);
        }

        [TestMethod]
        public void ExampleTestFail()
        {
            Item i = new()
            {
                Name = "My dad"
            };
            Assert.AreEqual("My Dad", i.Name);
        }

        [TestMethod]
        public void ExampleTestError()
        {
            Item i = new();
            Assert.ThrowsException<NullReferenceException>(i.Name!.ToLower);
        }
    }
}