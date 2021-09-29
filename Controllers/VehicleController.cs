using ExpressDLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetVehicle() {

            return Content("HELLO");

        }

        public IActionResult EditVehicleById()
        {

            return Content("HELLO");

        }
        // add vehicle Form
        // Must Call Add Vehicle API in Future
        [HttpGet]
        public IActionResult AddVehicle() {

            return View();
        }
        [HttpGet]
        public IActionResult AddVehicle(Vehicle vehicle)
        {

            return Content("Hello");
        }

        [HttpGet]
        public IActionResult ViewAllVehicles() {

            List<Vehicle> mockdb = new List<Vehicle>();

            mockdb.Add(new Vehicle { id = 0 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "16Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 150, PlateNo = "ND096384", RegNo = "12H7DBI2HBB2EE2", DriverId ="David002" });
            mockdb.Add(new Vehicle { id = 1 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "14Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 100, PlateNo = "ND096484", RegNo = "1CD34BI2HB465E2", DriverId ="Sam005" });
            mockdb.Add(new Vehicle { id = 2 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "16Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 100, PlateNo = "ND023484", RegNo = "12H7DBI2HB654E2", DriverId ="James011" });
            mockdb.Add(new Vehicle { id = 3 , VehicleId = Guid.NewGuid().ToString() , Branch = "Johannesburg", Class =  "14Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 90, PlateNo = "JNB06584", RegNo = "1RFEFFR3545B265", DriverId ="Derric012" });

            return View(mockdb);
        }

        public IActionResult SearchForVehicle()
        {

            return Content("Hello");
        }
    }
}
