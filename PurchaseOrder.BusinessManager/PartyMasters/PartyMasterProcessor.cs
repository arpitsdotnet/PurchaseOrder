
using PurchaseOrder.DataManager.PartyMasters;
using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager.PartyMasters
{
    public class PartyMasterProcessor : IPartyMasterProcessor
    {
        private readonly IPartyMasterRepository _partyMasterRepo;

        public PartyMasterProcessor()
        {
            this._partyMasterRepo = new PartyMasterRepository();
        }

        public PartyMasterProcessor(IPartyMasterRepository partyMasterRepo)
        {
            this._partyMasterRepo = partyMasterRepo;
        }

        public int Delete(int ID)
        {
            try
            {
                return _partyMasterRepo.Delete(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Edit(int ID, PartyMasterModel model)
        {
            try
            {
                return _partyMasterRepo.Edit(ID, model);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<PartyMasterModel> GetAll()
        {
            try
            {
                return _partyMasterRepo.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public PartyMasterModel GetByID(int ID)
        {
            try
            {
                return _partyMasterRepo.GetByID(ID);
            }
            catch
            {
                throw;
            }
        }

        public int Save(PartyMasterModel model)
        {
            try
            {
                return _partyMasterRepo.Save(model);
            }
            catch
            {
                throw;
            }
        }
    }
}
