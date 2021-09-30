using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExpressDLL.Models
{
    public class Waybill
    {
        [Key]
        public int id { get; set; }
        public string WaybillId { get; set; }
        public string ItemId { get; set; }
        public string ParcelId { get; set; }
        public string Quantity { get; set; }
        public int Weight { get; set; }

        public DateTime InTime { get; set; }
        public DateTime ETA { get; set; }
        public DateTime OutTime { get; set; }

        public string ShipperSigniture { get; set; }
        public string ConigeeSigniture { get; set; }
    }
}
