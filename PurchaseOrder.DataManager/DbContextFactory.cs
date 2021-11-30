using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.DataManager
{
    public class DbContextFactory
    {
        // Private Constructor to restrict object creation.
        private DbContextFactory() { }

        // Singleton Thread Safe Object Creation
        private static readonly Lazy<IDbContext> _Instance = new Lazy<IDbContext>(() => new SQLDataAccess());

        // Instance Property to get the object
        public static IDbContext Instance
        {
            get
            {
                return _Instance.Value;
            }
        }
    }
}
