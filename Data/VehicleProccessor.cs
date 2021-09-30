using ExpressDLL.Interfaces;
using ExpressDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Data
{
    public class VehicleProccessor : IVehicleRepository
    {
        private readonly ApplicationDbContext db;

        public VehicleProccessor(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(string id)
        {
            throw new NotImplementedException();
        }

        public Vehicle EditVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> FilterVehicles(string query, string cat)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(string id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> SearchVehicles(string query)
        {
            throw new NotImplementedException();
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
