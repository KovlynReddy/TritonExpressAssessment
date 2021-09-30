using ExpressDLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TritonExpress.Data;
using TritonExpress.Models.ViewModel;

namespace TritonExpress.Controllers
{
    public class ParcelController : Controller
    {
        private readonly ApplicationDbContext db;

        public ParcelController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddItem() {

            return View();
        }


        [HttpGet]
        public IActionResult AddParcel()
        {
            AddParcelViewModel model = new AddParcelViewModel();
            model.Items = db.Items.ToList();

            List<SelectListItem> item = model.Items.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.ItemName.ToString(),
                    Value = a.ItemId.ToString(),
                    Selected = false
                };
            });

            model.SelectItems = item;

            return View(model);
        }

        [HttpGet]
        public IActionResult AddWaybill()
        {
            AddWayBillViewModelDynamic model = new AddWayBillViewModelDynamic();
            //model.Items = db.Items.ToList();
            model.Vehicles = db.Vehicles.ToList();
            //List<SelectListItem> item = model.Items.ConvertAll(a =>
            //{
            //    return new SelectListItem()
            //    {
            //        Text = a.ItemName.ToString(),
            //        Value = a.ItemId.ToString(),
            //        Selected = false
            //    };
            //});

            model.Parcels = db.Parcels.ToList();

            return View(model);

        }

        [HttpPost]
        public IActionResult AddItem(Item item)
        {
            item.ItemId = Guid.NewGuid().ToString();

            db.Items.Add(item);
            db.SaveChanges();

            return View();
        }


        [HttpPost]
        public IActionResult AddParcel(Parcel parcel)
        {

            parcel.ParcelId = Guid.NewGuid().ToString();

            db.Parcels.Add(parcel);
            db.SaveChanges();

            return View();
        }

        [HttpPost]
        public IActionResult AddWaybill(AddWayBillViewModelDynamic waybill)
        {
            if (!waybill.Done)
            {
                var parcel = new Parcel{ ParcelId = waybill.ParcelId,Quantity = Convert.ToInt32(waybill.Quantity)};
                waybill.SelectedParcels.Add(parcel);
                waybill.Parcels = db.Parcels.ToList();
                return View(waybill);
            }
            waybill.WaybillId = Guid.NewGuid().ToString();
            foreach (var item in waybill.SelectedParcels)
            {
                var newwaybill = new Waybill();
                newwaybill.WaybillId = waybill.WaybillId;

                newwaybill.ETA = waybill.ETA ;
                newwaybill.InTime = waybill.InTime ;
                newwaybill.ItemId = waybill.ItemId;
                newwaybill.OutTime = waybill.OutTime;
                newwaybill.Quantity = waybill.SelectedParcels.Count.ToString();
                newwaybill.ParcelId = item.ParcelId;
                newwaybill.Weight = waybill.Weight;
                newwaybill.ShipperSigniture = User.Identity.Name;
                newwaybill.ConigeeSigniture = User.Identity.Name;

                db.Waybills.Add(newwaybill);
                db.SaveChanges();
            }

            return View();
        }

        [HttpGet]
        public IActionResult ViewAllWaybills()
        {
            var model = db.Waybills.ToList();
            return View(model);
        }
    }
}
