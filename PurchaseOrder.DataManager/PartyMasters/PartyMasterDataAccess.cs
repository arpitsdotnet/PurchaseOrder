using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager.PartyMasters
{
    public class PartyMasterDataAccess : IPartyMasterDataAccess
    {
        private readonly IDbContext _dbContext;

        public PartyMasterDataAccess()
        {
            this._dbContext = DbContextFactory.Instance;
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Edit(int ID, PartyMasterModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PartyMasterModel> GetAll()
        {
            try
            {
                var result = _dbContext.LoadData<PartyMasterModel, dynamic>("sps_tblPartyMaster_GetAll", new { });

                return result;
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
                var p = new { PartyID = ID };

                var result = _dbContext.LoadData<PartyMasterModel, dynamic>("sps_tblPartyMaster_GetByID", p);

                return result.FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public int Save(PartyMasterModel model)
        {
            throw new NotImplementedException();
        }
    }
}
