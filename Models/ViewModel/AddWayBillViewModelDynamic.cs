using ExpressDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Models.ViewModel
{
    public class AddWayBillViewModelDynamic : Waybill
    {
        public int Choices { get; set; }
        public bool Done { get; set; }
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();
        public List<Parcel> SelectedParcels { get; set; } = new List<Parcel>();
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public Parcel lastparcel { get; set; }
        public void AddParcel()
        {
            lastparcel = new ExpressDLL.Models.Parcel();
            SelectedParcels.Add(lastparcel);
        }

        public void RemoveParcel()
        {

            SelectedParcels.Remove(lastparcel);
        }
    }
}
