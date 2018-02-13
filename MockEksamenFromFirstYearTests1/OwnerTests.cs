using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamenFromFirstYear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamenFromFirstYear.Tests
{
    [TestClass()]
    public class OwnerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
           "Address skal have mere end 6 tegn")]
        public void AddressTest()
        {
            //Arrange
            Owner ejer = new Owner("Gart", "Linda", "40168797");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
           "Name skal have mere end 4 tegn")]
        public void NameTest()
        {
            //Arrange
            Owner ejer = new Owner("Gartnervang", "Per", "40168797");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
          "Phone skal have 8 tegn")]

        public void PhoneTest()
        {
            //Arrange
            Owner ejer = new Owner("Gartnervang", "Linda", "4016879");

        }
    }
}