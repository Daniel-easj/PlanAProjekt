
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanA.Data.Domain.ExtendedClasses;

namespace UnitTestPlanAv3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void PrivateCustomer_Name_GetOnce()
        {   // Arrange
            PrivateCustomer testSubject = new PrivateCustomer("Morten", "12345678", "Byvej", "Morten@gmail.com");
            string expectedResult = "Morten";

            // Act
            string actualResult = testSubject.Name;


            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void CompanyCustomer_GetCVR()
        {   // Arrange
            CompanyCustomer testSubject = new CompanyCustomer("Morten", "12345678", "Byvej", "Morten@gmail.com", "555");
            string expectedResult = "555";

            // Act
            string actualResult = testSubject.Cvr;


            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void PrivateCustomer_CheckName()
        {   // Arrange
            Assert.ThrowsException<ArgumentException>(() => { PrivateCustomer testSubject = new PrivateCustomer("  ", "12345678", "Hansvej", "bla"); });

        }
    }
}
