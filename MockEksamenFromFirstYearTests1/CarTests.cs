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
    public class CarTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
         "Dørene skal være en værdi mellem 2 og 5")]
        public void DoorsTest()
        {
            //Arrange
            Car.color farve = Car.color.Black;
            Car nybil = new Car(farve, 7, "peugeot", "BW81681");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
        "Modellen skal ikke være null")]

        public void ModelTest()
        {
            //Arrange
            Car.color farve = Car.color.Gray;
            Car nybil = new Car(farve, 8, null, "AK91345");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
         "RegistrationNr skal have nøjagtige 7 tegn")]

        public void RegistrationNoTest()
        {
            //Arrange
            Car.color farve = Car.color.Green;
            Car nybil = new Car(farve, 9, "Volvo", "GD68214");
        }
    }
}