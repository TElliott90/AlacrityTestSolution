using System;
using AlacrityTest.Models;
using System.Collections.Generic;

namespace AlacrityTest.Models
{
    public class CarDataInitialiser
    {

        public IEnumerable<CarModel> CarList { get; set; }



        public void CarListInitialiser()
        {
            CarList = new List<CarModel>()
            {
                new CarModel() {Make = "Aston Martin", Price= 50000, Year= 2012},
                new CarModel() {Make = "BMW", Price= 30000, Year= 2014},
                new CarModel() {Make = "Chevrolet", Price= 20000, Year= 2013},
                new CarModel() {Make = "Datsun", Price= 2000, Year= 2002},
            };

             

        }




    }
}
