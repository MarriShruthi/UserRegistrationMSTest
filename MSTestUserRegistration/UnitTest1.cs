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
        /// Validate Email Id
        /// </summary>
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in")]
        [DataRow("chinna.abc@bl.cp.in")]
        [DataRow("shru.dcd@bl.cp.in")]

        public void Given__Valid_Email_ShouldReturnTrue(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Email", e.Message);
            }
        }

        /// <summary>
        /// Test Method to pass invalid email id.
        /// </summary>
        [TestMethod]
        [DataRow("shruthi@gmail")]
        [DataRow("swetha@gmail.comm")]
        [DataRow("rishi@gmail.com.ind.us")]
        [DataRow("hima#100@gmail")]
        [DataRow("suma11@gmail.com.a12")]
        [DataRow("san@gmail.com.12sa")]
        [DataRow("_sid@gmail.com")]

        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }
    }
}