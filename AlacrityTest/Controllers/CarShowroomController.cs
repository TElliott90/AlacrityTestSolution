using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlacrityTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlacrityTest.Controllers
{
    public class CarShowroomController : Controller
    {
        CarDataInitialiser carData = new CarDataInitialiser();

        // GET: /<controller>/
        public IActionResult Index()
        {
            

            carData.CarListInitialiser();
            var carList = carData.CarList;


            return View(carList);
        }


        public IActionResult Details(CarModel car)
        {

            return View(car);
        }



        [HttpPost]
        public IActionResult AddNewCar(string make, int price, int year)
        {
            CarModel newCar = new CarModel(make, price, year);

            //Need to re-initialise the list (repopulated after page is refreshed)
            carData.CarListInitialiser();

            carData.CarList.Append(newCar);

            return View(carData.CarList);
        }
    }
}
