using PurchaseOrder.Services.Models;

namespace PurchaseOrder.BusinessManager.PODetails
{
    public interface IPODetailsProcessor : IBaseProcessor<PODetailsModel>
    {
        PODetailsModel GetByPOID(int POID);
    }
}
