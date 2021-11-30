using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager.ItemMasters
{
    public class ItemMasterRepository : IItemMasterRepository
    {
        private readonly IDbContext _dbContext;

        public ItemMasterRepository()
        {
            this._dbContext = DbContextFactory.Instance;
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Edit(int ID, ItemMasterModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemMasterModel> GetAll()
        {
            try
            {
                var result = _dbContext.LoadData<ItemMasterModel, dynamic>("sps_tblItemMaster_GetAll", new { });

                return result;
            }
            catch
            {
                throw;
            }
        }

        public ItemMasterModel GetByID(int ID)
        {
            try
            {
                var p = new { ItemID = ID };

                var result = _dbContext.LoadData<ItemMasterModel, dynamic>("sps_tblItemMaster_GetByID", p);

                return result.FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public int Save(ItemMasterModel model)
        {
            throw new NotImplementedException();
        }
    }
}
