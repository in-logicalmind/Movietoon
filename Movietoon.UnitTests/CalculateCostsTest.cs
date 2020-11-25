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

            var expected = Decimal.Round((Decimal)0.8,2);
            var resultDec = Decimal.Round((Decimal)result, 2);
            try
            {
                Assert.AreEqual(expected, resultDec);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
