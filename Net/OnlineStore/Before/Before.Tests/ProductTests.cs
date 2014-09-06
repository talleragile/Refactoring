using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Before.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void SerializeToXml()
        {
            Product product = CreateProduct();

            string xml = product.ToXml();

            Assert.AreEqual("<product><name>Black Bike</name><category>Bikes</category></product>", xml);
        }

        private Product CreateProduct()
        {
            return new Product("Black Bike", 250, Category.Bikes, new ImageInfo("Bike01.jpg"));
        }
    }
}