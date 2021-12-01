using PurchaseOrder.BusinessManager.ItemMasters;
using PurchaseOrder.BusinessManager.PartyMasters;
using PurchaseOrder.BusinessManager.PODetails;
using PurchaseOrder.BusinessManager.POMasters;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PurchaseOrder.WebUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IItemMasterProcessor, ItemMasterProcessor>();
            container.RegisterType<IPartyMasterProcessor, PartyMasterProcessor>();
            container.RegisterType<IPODetailsProcessor, PODetailsProcessor>();
            container.RegisterType<IPOMasterProcessor, POMasterProcessor>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}