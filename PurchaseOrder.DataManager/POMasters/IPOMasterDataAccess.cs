using PurchaseOrder.Services.Models;
using System.Collections.Generic;

namespace PurchaseOrder.DataManager.POMasters
{
    public interface IPOMasterDataAccess : IRepository<POMasterModel>
    {
        POMasterModel GetByPONo(string PONo);
    }
}