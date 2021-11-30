using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager.PODetails
{
    public class PODetailsDataAccess : IRepository<PODetailsModel>
    {
        private readonly IDbContext _dbContext;

        public PODetailsDataAccess()
        {
            this._dbContext = DbContextFactory.Instance;
        }

        public int Delete(int ID)
        {
            try
            {
                var p = new { POID = ID };

                var result = _dbContext.SaveData("spd_tblPODetails_Delete", p);

                return result;
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
                var p = new
                {
                    POID = ID,
                    model.ItemID,
                    model.Qty,
                    model.Rate,
                    model.Amount,
                    model.DiscPer,
                    model.Discount,
                    model.TotalAmt
                };

                var result = _dbContext.SaveData("spu_tblPODetails_Update", p);

                return result;
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
                var result = _dbContext.LoadData<PODetailsModel, dynamic>("sps_tblPODetails_GetAll", new { });

                return result;
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
                var p = new { POID = ID };

                var result = _dbContext.LoadData<PODetailsModel, dynamic>("sps_tblPODetails_GetByID", p);

                return result.FirstOrDefault();
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
                var p = new
                {
                    model.POID,
                    model.ItemID,
                    model.Qty,
                    model.Rate,
                    model.Amount,
                    model.DiscPer,
                    model.Discount,
                    model.TotalAmt
                };

                var result = _dbContext.SaveData("spi_tblPODetails_Insert", p);

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
