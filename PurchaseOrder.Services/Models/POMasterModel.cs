using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Services.Models
{
    public class POMasterModel
    {
        public int POID { get; set; }

        [Display(Name = "PO Number ")]
        public string PONo { get; set; }

        [Display(Name = "PO Date")]
        public DateTime PODate { get; set; }

        [Display(Name = "Party")]
        public int PartyID { get; set; }
        public virtual PartyMasterModel PartyMaster { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Total Qty")]
        public decimal TotalQty { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Total Discount")]
        public decimal TotalDiscount { get; set; }

        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }
        public string Terms { get; set; }
    }
}
