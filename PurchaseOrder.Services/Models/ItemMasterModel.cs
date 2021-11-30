using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Services.Models
{
    public class ItemMasterModel
    {
        public int ItemID { get; set; }

        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
    }
}
