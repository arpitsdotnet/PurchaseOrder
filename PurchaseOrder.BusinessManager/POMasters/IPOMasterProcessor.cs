using PurchaseOrder.Services.Models;

namespace PurchaseOrder.BusinessManager.POMasters
{
    public interface IPOMasterProcessor : IBaseProcessor<POMasterModel>
    {
        POMasterModel GetByPONo(string PONo);
    }
}
