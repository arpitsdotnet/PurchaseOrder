
using PurchaseOrder.DataManager.PODetails;
using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager.PODetails
{
    public class PODetailsProcessor : IPODetailsProcessor
    {
        private readonly IPODetailsRepository _poDetailsRepo;

        public PODetailsProcessor()
        {
            this._poDetailsRepo = new PODetailsRepository();
        }

        public PODetailsProcessor(IPODetailsRepository poDetailsRepo)
        {
            this._poDetailsRepo = poDetailsRepo;
        }

        public int Delete(int ID)
        {
            try
            {
                return _poDetailsRepo.Delete(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Edit(int ID, PODetailsModel model)
        {
            try
            {
                return _poDetailsRepo.Edit(ID, model);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<PODetailsModel> GetAll()
        {
            try
            {
                return _poDetailsRepo.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public PODetailsModel GetByID(int ID)
        {
            try
            {
                return _poDetailsRepo.GetByID(ID);
            }
            catch
            {
                throw;
            }
        }

        public List<PODetailsModel> GetByPOID(int POID)
        {
            try
            {
                return _poDetailsRepo.GetByPOID(POID);
            }
            catch
            {
                throw;
            }
        }

        public int Save(PODetailsModel model)
        {
            try
            {
                return _poDetailsRepo.Save(model);
            }
            catch
            {
                throw;
            }
        }
    }
}
