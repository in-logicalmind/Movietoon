using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movietoon.Models;

namespace Movietoon.UnitTests
{
    [TestClass]
    public class CalculateCostsTest
    {
        [TestMethod]
        public void CalculateCostsMovie_ValidMembership_returnsValue()
        {
            var calculatedCosts = new CalculateCosts();

            //Arrange
            var result = calculatedCosts.CalculateCostsMovie(
                new MembershipType {Description = "Quarterly", DiscountPct = 20, Months = 3},
                new Movie {Price = 1, Title = "Test movie"});

            var expected = 0.8;

            Assert.AreEqual(expected, result);
        }
    }
}
