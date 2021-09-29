using ExpressDLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TritonExpress.Data;

namespace TritonExpress.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext db;

        public VehicleController(ApplicationDbContext db)
        {
            this.db = db;
        }
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

        [HttpGet]
        public IActionResult UpdateVehicle(string id)
        {

            var vehicles = db.Vehicles.ToList();
            var vehicle = vehicles.FirstOrDefault(m => m.VehicleId == id);
            db.SaveChanges();
            return View(vehicle);

        }

        [HttpPost]
        public IActionResult UpdateVehicle(Vehicle vehicle) {

            var selectedvehicle = db.Vehicles.FirstOrDefault(m=> m.VehicleId == vehicle.VehicleId);
            vehicle.id = selectedvehicle.id;

            selectedvehicle.Color = vehicle.Color;
            selectedvehicle.DriverId = vehicle.DriverId;
            selectedvehicle.Class = vehicle.Class;
            selectedvehicle.Branch = vehicle.Branch;
            selectedvehicle.Make = vehicle.Make;
            selectedvehicle.MaxTonnage = vehicle.MaxTonnage;
            selectedvehicle.PlateNo = vehicle.PlateNo;
            selectedvehicle.RegNo = vehicle.RegNo;

            //db.Vehicles.Attach(selectedvehicle);

            db.Entry(selectedvehicle).State = EntityState.Modified;
           
            db.SaveChanges();


            return View(vehicle);

        }
        // add vehicle Form
        // Must Call Add Vehicle API in Future

        [HttpGet]
        public IActionResult AddVehicle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddVehicle(Vehicle vehicle)
        {
            vehicle.VehicleId = Guid.NewGuid().ToString();

            db.Vehicles.Add(vehicle);
            db.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult ViewAllVehicles() {

            var vehicles = db.Vehicles.ToList();

            List<Vehicle> mockdb = new List<Vehicle>();

            mockdb.Add(new Vehicle { id = 0 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "16Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 150, PlateNo = "ND096384", RegNo = "12H7DBI2HBB2EE2", DriverId ="David002" });
            mockdb.Add(new Vehicle { id = 1 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "14Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 100, PlateNo = "ND096484", RegNo = "1CD34BI2HB465E2", DriverId ="Sam005" });
            mockdb.Add(new Vehicle { id = 2 , VehicleId = Guid.NewGuid().ToString() , Branch = "Durban", Class =  "16Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 100, PlateNo = "ND023484", RegNo = "12H7DBI2HB654E2", DriverId ="James011" });
            mockdb.Add(new Vehicle { id = 3 , VehicleId = Guid.NewGuid().ToString() , Branch = "Johannesburg", Class =  "14Wheeler" , Color = "Blue" , Make = "MAN", MaxTonnage = 90, PlateNo = "JNB06584", RegNo = "1RFEFFR3545B265", DriverId ="Derric012" });

            mockdb.AddRange(vehicles);

            return View(mockdb);
        }

        public IActionResult SearchForVehicle()
        {

            return Content("Hello");
        }
    }
}
