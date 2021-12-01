using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.BusinessManager.PODetails
{
    public interface IPODetailsProcessor : IBaseProcessor<PODetailsModel>
    {
        List<PODetailsModel> GetByPOID(int POID);
    }
}
