using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Services.Models
{
    public class PODetailsModel
    {
        public int PODetailsID { get; set; }

        [Display(Name = "PO")]
        public int POID { get; set; }
        public virtual POMasterModel POMaster { get; set; }

        [Display(Name = "Item")]
        public int ItemID { get; set; }
        public virtual ItemMasterModel ItemMaster { get; set; }

        public int Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        [Display(Name = "Discount Percentage")]
        public decimal DiscPer { get; set; }
        public decimal Discount { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmt { get; set; }
    }
}
