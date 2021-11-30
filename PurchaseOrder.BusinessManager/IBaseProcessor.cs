using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager
{
    public interface IBaseProcessor<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int ID);
        int Save(T model);
        int Edit(int ID, T model);
        int Delete(int ID);
    }
}
