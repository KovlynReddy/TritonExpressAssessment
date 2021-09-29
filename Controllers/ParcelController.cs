using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Controllers
{
    public class ParcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem() {

            return View();
        }


        public IActionResult AddParcel()
        {

            return View();
        }


        public IActionResult AddWaybill()
        {

            return View();
        }
    }
}
