using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExpressDLL.Models
{
    public class Vehicle
    {
        [Key]
        public int id { get; set; }
        public string VehicleId { get; set; }

        // create enum
        public string Branch { get; set; }

        public string Make { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        // optional
        public int MaxTonnage { get; set; }
        
        public string PlateNo { get; set; }
        public string RegNo { get; set; }
        public string DriverId { get; set; }



    }
}
