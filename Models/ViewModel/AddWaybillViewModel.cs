using ExpressDLL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Models.ViewModel
{
    public class AddWaybillViewModel : Waybill
    {
        public List<Parcel> Parcels { get; set; }
        public List<Item> Items { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public string VehicleId { get; set; }
        public List<SelectListItem> SelectItems { get; set; }
    
}
}
