using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager.PODetails
{
    public class PODetailsRepository : IPODetailsRepository
    {
        private readonly IDbContext _dbContext;

        public PODetailsRepository()
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
                    model.Details,
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
                var p = new { PODetailsID = ID };

                var result = _dbContext.LoadData<PODetailsModel, dynamic>("sps_tblPODetails_GetByID", p);

                return result.FirstOrDefault();
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
                var p = new { POID };

                var result = _dbContext.LoadData<PODetailsModel, dynamic>("sps_tblPODetails_GetByPOID", p);

                return result;
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
                    model.Details,
                    model.Qty,
                    model.Rate,
                    model.Amount,
                    model.DiscPer,
                    model.Discount,
                    model.TotalAmt
                };

                //var result = _dbContext.SaveData("spi_tblPODetails_Insert", p);
                var result = _dbContext.SaveDataOutParam<dynamic, int>("spi_tblPODetails_Insert", p, out int PODetailsID, System.Data.DbType.Int32, null, "ID");


                if (result > 0)
                {
                    model.PODetailsID = PODetailsID;
                }

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
