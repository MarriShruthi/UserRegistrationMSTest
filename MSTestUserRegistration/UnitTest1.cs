using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        private readonly UserDetail userDetailsPattern;
        //private readonly object DataRow;

        //parameterless constructor
        public Test()
        {
            userDetailsPattern = new UserDetail(); //object of UserDetail and store the userDetailsPattern variable
        }

        /// <summary>
        /// Validate MobileNumber
        /// </summary>
        [TestMethod]
        [DataRow("91 9123456789")]
        [DataRow("91 9123456780")]
        [DataRow("91 9087654321")]

        public void Given__Valid_MobileNumber_ShouldReturnTrue(string validMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(validMobile);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Mobile Number", e.Message);
            }
        }

        /// <summary>
        /// passing invalid mobile number patterns should return invalid mobile number
        /// </summary>
        [TestMethod]
        [DataRow("91 123456")]
        [DataRow("91 1234567")]
        [DataRow("91 9876")]
        [DataRow("91 876543")]
        [DataRow("91 98234555")]
        [DataRow("91 91234567")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(invalidMobile);

            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid mobile number", e.Message);
            }
        }
    }
}