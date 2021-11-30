using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.DataManager.PODetails
{
    public interface IPODetailsRepository : IRepository<PODetailsModel>
    {
        PODetailsModel GetByPOID(int POID);
    }
}