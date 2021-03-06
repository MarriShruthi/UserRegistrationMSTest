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
        /// Validate Password
        /// </summary>
        [TestMethod]
        [DataRow("Abc@1234")]
        [DataRow("Adef@345")]
        [DataRow("Shru@456")]

        public void Given__Valid_Password_ShouldReturnTrue(string validPass)
        {
            try
            {
                string result = userDetailsPattern.ValidatePassword(validPass);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Password", e.Message);
            }
        }

        /// <summary>
        /// passing invalid Password patterns should return invalid Password
        /// </summary>
        [TestMethod]
        [DataRow("xyz//")]
        [DataRow("PQR@@")]
        [DataRow("ABC$$")]

        public void GivenInvalidPassword_ShouldReturnFalse(string invalidPassword)
        {
            try
            {
                string result = userDetailsPattern.ValidatePassword(invalidPassword);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }
    }
}