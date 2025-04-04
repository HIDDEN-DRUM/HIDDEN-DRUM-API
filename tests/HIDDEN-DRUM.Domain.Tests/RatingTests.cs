using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HIDDEN_DRUM.Domain;


namespace HIDDEN_DRUM.Domain
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            // Arrange
            var rating = new Rating(5, "Mike", "Great fit!");

            // Assert
            Assert.AreEqual(5, rating.Stars);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cannot_Create_Rating_With_Invalid_Stars()
        {
            // Arrange - using 0 stars, which should trigger the exception
            var rating = new Rating(0, "Mike", "Great fit!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cannot_Create_Rating_With_Empty_UserName()
        {
            // Arrange - using empty username
            var rating = new Rating(4, "", "Still pretty good!");
        }
    
    }
}



