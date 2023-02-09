using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GRHW;

namespace GRHWUnitTesting
{
    [TestClass]
    public class GRHWTesting
    {
        //Methods to Test - getCustomerList - returns a list of customers
        //
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            //double beginningBalance = 11.99;
            //double debitAmount = 4.55;
            //double expected = 7.44;
            Customer customer = new Customer();
            customer.LastName = "Chalmers";
            customer.FirstName = "Helen";
            customer.Email = "hchalmers@gmail.com";
            customer.FavoriteColor = "blue";
            customer.DateOfBirth = "03/25/1984";

            // Act
            

            // Assert
            //double actual = account.Balance;
            //Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
