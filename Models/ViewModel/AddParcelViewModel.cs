using ExpressDLL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TritonExpress.Models.ViewModel
{
    public class AddParcelViewModel : Parcel
    {
        public List<Item> Items { get; set; }
        public List<SelectListItem> SelectItems { get; set; }
    }
}
