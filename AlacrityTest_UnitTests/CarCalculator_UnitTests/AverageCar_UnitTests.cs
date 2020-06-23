using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlacrityTest.Models;

namespace AlacrityTest_UnitTests
{
    [TestClass]
    public class AverageCar_UnitTests
    {
        CarDataInitialiser initialiser = new CarDataInitialiser();
        CarCalculator calc = new CarCalculator();


        [TestMethod]
        public void CarCalculator_ReturnsAverage_Correct()
        {
            //Arrange
            CarCalculator calc = new CarCalculator();
            initialiser.CarListInitialiser();
            var carList = initialiser.CarList;

            //Act
            var result = calc.AveragePriceCalculator(carList);


            //Assert
            Assert.AreEqual(25500, result);

        }
    }
}
