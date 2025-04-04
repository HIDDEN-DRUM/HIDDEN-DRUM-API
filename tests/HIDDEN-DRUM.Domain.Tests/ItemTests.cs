using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HIDDEN_DRUM.Domain;

namespace HIDDEN_DRUM.Domain.Catalog
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            // Arrange
            var item = new Item("Name", "Description", "Brand", 10.00m);

            // Assert
            Assert.AreEqual("Name", item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
        }
    }
}

    



