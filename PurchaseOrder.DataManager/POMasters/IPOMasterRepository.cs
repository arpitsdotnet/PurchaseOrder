using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.DataManager.POMasters
{
    public interface IPOMasterRepository : IRepository<POMasterModel>
    {
        POMasterModel GetByPONo(string PONo);
    }
}