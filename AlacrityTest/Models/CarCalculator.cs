using System;
using System.Collections.Generic;
using System.Linq;

namespace AlacrityTest.Models
{
    public class CarCalculator
    {

        public int AveragePriceCalculator(IEnumerable<CarModel> carList)
        {
            var numberOfCars = 0;
            var totalPrice = 0;

            foreach(CarModel c in carList)
            {
                numberOfCars += 1;
                totalPrice += c.Price;
            };

            return totalPrice / numberOfCars;

        }

        public string ReturnOldestCar(IEnumerable<CarModel> carList)
        {
            var oldestCar = carList.OrderBy(x => x.Year).ElementAt(0);

            var message = $"The oldest car is the {oldestCar.Year}, {oldestCar.Make}.";
            return message;

        }

        public string ReturnMostExpensiveCar(IEnumerable<CarModel> carList)
        {
            var sortedList = carList.OrderByDescending(x => x.Price);
            var expensiveCar = sortedList.ElementAt(0);

            var message = $"The most expensive car is the {expensiveCar.Year}, {expensiveCar.Make}.";
            return message;

        }
    }
}
