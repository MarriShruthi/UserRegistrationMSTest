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
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Shruthi")]
        [DataRow("Rishika")]
        [DataRow("Swetha")]
        [DataRow("Hema")]
        [DataRow("Suma")]
        [DataRow("Hima")]

        public void Given_LasttName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(name);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Last Name", e.Message);
            }
        }
        ///// <summary>
        ///// Test Method to Invalidate first name
        ///// </summary>
        [TestMethod]
        [DataRow("San")]
        [DataRow("Tina")]
        [DataRow("Swathi")]


        public void GivenLasttName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidLastName)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(invalidLastName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
    }
}
