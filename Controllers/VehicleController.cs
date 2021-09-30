using ExpressDLL.Interfaces;
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
        private readonly IVehicleRepository repo;

        public VehicleController(ApplicationDbContext db, IVehicleRepository repo)
        {
            this.db = db;
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region APIS
        [HttpGet]
        public IActionResult GetVehicle(string id)
        {
            var vehicles = db.Vehicles.ToList();

            vehicles = vehicles.Where(m => m.VehicleId == id).ToList();


            return Content("HELLO");

        }
        [HttpGet]
        public IActionResult EditVehicleById(string id, string cat, string val)
        {
            var vehicle = db.Vehicles.ToList();

            var vehicles = vehicle.Where(m => m.VehicleId == id).ToList().FirstOrDefault();

            switch (cat)
            {
                case "Class":
                    vehicles.Class = val;
                    break;

                case "Colour":
                    vehicles.Color = val;
                    break;

                case "Make":
                    vehicles.Make = val;
                    break;

                case "Driver":
                    vehicles.DriverId = val;
                    break;

                case "RegNo":
                    vehicles.RegNo = val;
                    break;

                case "NoPlate":
                    vehicles.PlateNo = val;
                    break;

                case "Branch":
                    vehicles.Branch = val;
                    break;

                default:
                    vehicles.DriverId = val;
                    break;
            }

            return Content("HELLO");

        }
        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = db.Vehicles.ToList();

            return Content("Hello");
        }
        [HttpGet]
        public IActionResult FilterVehicles(string id, string query)
        {
            var vehicles = db.Vehicles.ToList();

            switch (query)
            {
                case "Class":
                    vehicles = vehicles.Where(m => m.Class == id).ToList();
                    break;

                case "Colour":
                    vehicles = vehicles.Where(m => m.Color == id).ToList();
                    break;

                case "Make":
                    vehicles = vehicles.Where(m => m.Make == id).ToList();
                    break;

                case "Driver":
                    vehicles = vehicles.Where(m => m.DriverId == id).ToList();
                    break;

                case "RegNo":
                    vehicles = vehicles.Where(m => m.RegNo == id).ToList();
                    break;

                case "NoPlate":
                    vehicles = vehicles.Where(m => m.PlateNo == id).ToList();
                    break;

                case "Branch":
                    vehicles = vehicles.Where(m => m.PlateNo == id).ToList();
                    break;

                default:
                    vehicles = vehicles.Where(m => m.Branch == id).ToList();
                    break;
            }


            return Content("Hello");
        }
        [HttpGet]
        public IActionResult SearchVehicle(string id)
        {
            var vehicles = db.Vehicles.ToList();

            vehicles = vehicles.Where(m => m.VehicleId.Contains(id) || m.Branch.Contains(id) || m.Class.Contains(id) || m.Color.Contains(id) || m.DriverId.Contains(id) ||  m.DriverId.Contains(id) || m.Make.Contains(id) || m.PlateNo.Contains(id) || m.PlateNo.Contains(id) || m.RegNo.Contains(id) || m.VehicleId.Contains(id)).ToList();
           // vehicles = vehicles.Where(m => m.VehicleId == id || m.Branch == id || m.Class == id || m.Color == id || m.DriverId == id ||  m.DriverId == id || m.Make == id || m.PlateNo == id || m.PlateNo == id || m.RegNo == id || m.VehicleId == id).ToList();

            return Content("Hello");
        } 
        #endregion


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
