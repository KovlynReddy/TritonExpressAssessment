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
            AddWaybillViewModel model = new AddWaybillViewModel();
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
            model.Parcels = db.Parcels.ToList();

            model.SelectItems = item;

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
        public IActionResult AddWaybill(Waybill waybill)
        {
            waybill.WaybillId = Guid.NewGuid().ToString();

            db.Waybills.Add(waybill);
            db.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult ViewAllWaybills()
        {

            return View();
        }
    }
}
