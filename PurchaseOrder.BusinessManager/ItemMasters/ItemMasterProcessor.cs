using PurchaseOrder.DataManager.ItemMasters;
using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager.ItemMasters
{
    public class ItemMasterProcessor : IItemMasterProcessor
    {
        private readonly IItemMasterRepository _itemMasterRepo;

        public ItemMasterProcessor()
        {
            this._itemMasterRepo = new ItemMasterRepository();
        }
        public ItemMasterProcessor(IItemMasterRepository itemMasterRepo)
        {
            this._itemMasterRepo = itemMasterRepo;
        }

        public int Delete(int ID)
        {
            try
            {
                return _itemMasterRepo.Delete(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Edit(int ID, ItemMasterModel model)
        {
            try
            {
                return _itemMasterRepo.Edit(ID, model);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ItemMasterModel> GetAll()
        {
            try
            {
                return _itemMasterRepo.GetAll();
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
                return _itemMasterRepo.GetByID(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Save(ItemMasterModel model)
        {
            try
            {
                return _itemMasterRepo.Save(model);
            }
            catch
            {
                throw;
            }
        }
    }
}
