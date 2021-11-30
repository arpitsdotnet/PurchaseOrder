using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Services.Models
{
  public  class PartyMasterModel
    {
        public int PartyID { get; set; }

        [Display(Name = "Party Name")]
        public string PartyName { get; set; }
        public string City { get; set; }
    }
}
