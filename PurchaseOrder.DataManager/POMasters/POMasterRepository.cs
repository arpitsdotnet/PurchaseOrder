﻿using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager.POMasters
{
    public class POMasterRepository : IPOMasterRepository
    {
        private readonly IDbContext _dbContext;

        public POMasterRepository()
        {
            this._dbContext = DbContextFactory.Instance;
        }

        public int Delete(int ID)
        {
            try
            {
                var p = new { POID = ID };

                var result = _dbContext.SaveData("spd_tblPOMaster_Delete", p);

                return result;
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
                var p = new
                {
                    POID = ID,
                    model.PONo,
                    model.PODate,
                    model.PartyID,
                    model.Remarks,
                    model.TotalQty,
                    model.TotalAmount,
                    model.TotalDiscount,
                    model.GrandTotal,
                    model.Terms
                };

                var result = _dbContext.SaveData("spu_tblPOMaster_Update", p);

                return result;
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
                var result = _dbContext.LoadData<POMasterModel, dynamic>("sps_tblPOMaster_GetAll", new { });

                return result;
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
                var p = new { POID = ID };

                var result = _dbContext.LoadData<POMasterModel, dynamic>("sps_tblPOMaster_GetByID", p);

                return result.FirstOrDefault();
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
                var p = new { PONo };

                var result = _dbContext.LoadData<POMasterModel, dynamic>("sps_tblPOMaster_GetByPONo", p);

                return result.FirstOrDefault();
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
                var p = new
                {
                    model.PONo,
                    model.PODate,
                    model.PartyID,
                    model.Remarks,
                    model.TotalQty,
                    model.TotalAmount,
                    model.TotalDiscount,
                    model.GrandTotal,
                    model.Terms
                };

                //var result = _dbContext.SaveData("spi_tblPOMaster_Insert", p);
                var result = _dbContext.SaveDataOutParam<dynamic, int>("spi_tblPOMaster_Insert", p, out int POID, System.Data.DbType.Int32, null, "ID");

                if (result > 0)
                {
                    model.POID = POID;
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
