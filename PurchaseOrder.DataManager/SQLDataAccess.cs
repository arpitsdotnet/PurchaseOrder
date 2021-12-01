using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager
{
    internal class SQLDataAccess : IDbContext
    {

        private string ConnectionString => ConfigurationManager.ConnectionStrings["FWT_PurchaseOrder_Connection"].ConnectionString;
       
        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    List<T> rows = con.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();

                    return rows;
                }
            }
            catch
            {
                throw;
            }
        }

        public int SaveData<T>(string storedProcedure, T parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    int i = con.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                    return i;
                }
            }
            catch
            {
                throw;
            }
        }

        public int SaveDataOutParam<T, U>(string storedProcedure, T parameters, out U returnVar, DbType outputDbType, int? size, string outputVarName)
        {
            try
            {
                var dynamicp = new Dapper.DynamicParameters();
                dynamicp.AddDynamicParams(parameters);

                if (size == null)
                    dynamicp.Add(outputVarName, null, dbType: outputDbType, direction: ParameterDirection.Output);
                else
                    dynamicp.Add(outputVarName, null, dbType: outputDbType, direction: ParameterDirection.Output, size);

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    int i = con.Execute(storedProcedure, dynamicp, commandType: CommandType.StoredProcedure);

                    returnVar = dynamicp.Get<U>(outputVarName);

                    return i;
                }
            }
            catch
            {
                throw;
            }
        }

        //public int SaveDataWithSubdata<T, U, V>(string storedProcedureT, string storedProcedureU, T model, List<U> submodel, string modelIdName, out V returnVar, DbType outputDbType, int? size, string outputVarName)
        //{
        //    throw new NotImplementedException();
        //}

        //public int SaveMultipleData<T>(string storedProcedure, List<T> parameters)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
