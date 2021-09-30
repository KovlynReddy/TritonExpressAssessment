using ExpressDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Models.ViewModel
{
    public class SelectParcelViewModel : Parcel
    {
        public List<Parcel> Parcels { get; set; }
        public Parcel Selected { get; set; }
        public int Quanitity { get; set; }
        public int TotalWeight { get; set; }
    }
}
