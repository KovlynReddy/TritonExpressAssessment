using ExpressDLL.Interfaces;
using ExpressDLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ExpressDLL.DataAccess;
using System.Linq;

namespace ExpressDLL.DataAccess
{
    public class VehicleRepository : IVehicleRepository
    {
        public VehicleRepository()
        {

        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            string sql = $@" insert into dbo.VehicleDB
                        (VehicleId,Branch,Make,Color,Class,MaxTonnage,PlatNo,RegNo,DriverId)
                        values (@VehicleId,@Branch,@Make,@Color,@Class,@MaxTonnage,@PlatNo,@RegNo,@DriverId)";

            ExpressDLL.DataAccess.ExpressDBConnextion.SaveData<Vehicle>(sql, vehicle);
            return vehicle;
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
            string sql = $@" select * from dbo.VehicleDB";

            return ExpressDBConnextion.LoadData<Vehicle>(sql).ToList();
        }

        public Vehicle GetVehicle(string id)
        {
            string sql = $@" select * from dbo.VehicleDB
                        WHERE ( VehicleId = '{id}')";

            return ExpressDBConnextion.LoadData<Vehicle>(sql).ToList().FirstOrDefault();
        }

        public List<Vehicle> SearchVehicles(string query)
        {
            string sql = $@" select * 
                            from [dbo].[VehicleDB]
                            where( Branch like '%{query}%'
                            or Driver like '%{query}%');";

           return ExpressDLL.DataAccess.ExpressDBConnextion.FindData<Vehicle>(sql);
          
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            string sql = $@"update [dbo].[VehicleDB] 
            SET Branch = '{vehicle.Branch}',
             DriverId = '{vehicle.DriverId}'
            where  Color = '{vehicle.Color}';";


            ExpressDLL.DataAccess.ExpressDBConnextion.UpdateData<Vehicle>(sql);
            return vehicle;
        }
    }
}
