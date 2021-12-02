using PurchaseOrder.DataManager.POMasters;
using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager.POMasters
{
    public class POMasterProcessor : IPOMasterProcessor
    {
        private readonly IPOMasterRepository _poMasterRepo;

        public POMasterProcessor()
        {
            this._poMasterRepo = new POMasterRepository();
        }

        public POMasterProcessor(IPOMasterRepository poMasterRepo)
        {
            this._poMasterRepo = poMasterRepo;
        }

        public int Delete(int ID)
        {
            try
            {
                return _poMasterRepo.Delete(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Edit(int ID, POMasterModel model)
        {
            try
            {
                return _poMasterRepo.Edit(ID, model);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<POMasterModel> GetAll()
        {
            try
            {
                return _poMasterRepo.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public POMasterModel GetByID(int ID)
        {
            try
            {
                return _poMasterRepo.GetByID(ID);
            }
            catch
            {
                throw;
            }
        }

        public POMasterModel GetByPONo(string PONo)
        {
            try
            {
                return _poMasterRepo.GetByPONo(PONo);
            }
            catch
            {
                throw;
            }
        }

        public int Save(POMasterModel model)
        {
            try
            {
                return _poMasterRepo.Save(model);
            }
            catch
            {
                throw;
            }
        }
    }
}
