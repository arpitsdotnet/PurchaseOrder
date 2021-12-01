using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.DataManager.PODetails
{
    public interface IPODetailsRepository : IRepository<PODetailsModel>
    {
        List<PODetailsModel> GetByPOID(int POID);
    }
}