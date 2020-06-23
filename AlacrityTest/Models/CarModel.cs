using System;
namespace AlacrityTest.Models
{
    public class CarModel
    {

        public string Make { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }


        public CarModel()
        {
        }

        public CarModel(string make, int price, int year)
        {
            Make = make;
            Price = price;
            Year = year;

        }
    }
}
