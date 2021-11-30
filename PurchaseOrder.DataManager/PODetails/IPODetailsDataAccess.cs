using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.DataManager.PODetails
{
    public interface IPODetailsDataAccess : IRepository<PODetailsModel>
    {
        PODetailsModel GetByPOID(int POID);
    }
}