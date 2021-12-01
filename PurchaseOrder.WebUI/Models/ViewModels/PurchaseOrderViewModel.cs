using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurchaseOrder.WebUI.Models.ViewModels
{
    public class PurchaseOrderViewModel
    {
        public IEnumerable<PartyMasterModel> PartyMasters { get; set; }
        public IEnumerable<ItemMasterModel> ItemMasters { get; set; }

        public POMasterModel PurchaseOrder { get; set; }
        public PODetailsModel PODetails { get; set; }
        public List<PODetailsModel> PODetailsList { get; set; }
    }
}