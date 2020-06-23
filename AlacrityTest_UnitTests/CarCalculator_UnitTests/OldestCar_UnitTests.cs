using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlacrityTest.Models;

namespace AlacrityTest_UnitTests
{
    [TestClass]
    public class OldestCar_UnitTests
    {
        CarDataInitialiser initialiser = new CarDataInitialiser();
        CarCalculator calc = new CarCalculator();

        [TestMethod]
        public void ReturnOldestCar_()
        {
            //Arrange
            CarCalculator calc = new CarCalculator();
            initialiser.CarListInitialiser();
            var carList = initialiser.CarList;


            //Act
            var result = calc.ReturnOldestCar(carList);


            //Assert
            Assert.AreEqual("The oldest car is the 2002, Datsun.", result);
        }
    }
}
