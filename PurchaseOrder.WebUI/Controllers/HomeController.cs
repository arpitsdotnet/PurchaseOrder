using Newtonsoft.Json;
using PurchaseOrder.BusinessManager.ItemMasters;
using PurchaseOrder.BusinessManager.PartyMasters;
using PurchaseOrder.BusinessManager.PODetails;
using PurchaseOrder.BusinessManager.POMasters;
using PurchaseOrder.Services.Models;
using PurchaseOrder.WebUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurchaseOrder.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPOMasterProcessor _poMasterProcessor;
        private readonly IPODetailsProcessor _poDetailsProcessor;
        private readonly IPartyMasterProcessor _partyMasterProcessor;
        private readonly IItemMasterProcessor _itemMasterProcessor;

        public HomeController(
            IPOMasterProcessor poMasterProcessor,
            IPODetailsProcessor poDetailsProcessor,
            IPartyMasterProcessor partyMasterProcessor,
            IItemMasterProcessor itemMasterProcessor
            )
        {
            this._poMasterProcessor = poMasterProcessor;
            this._poDetailsProcessor = poDetailsProcessor;
            this._partyMasterProcessor = partyMasterProcessor;
            this._itemMasterProcessor = itemMasterProcessor;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<POMasterModel> model = _poMasterProcessor.GetAll();

            foreach (var item in model)
            {
                item.PartyMaster = _partyMasterProcessor.GetByID(item.PartyID);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Save(int? id)
        {
            var modelVM = new PurchaseOrderViewModel
            {
                PartyMasters = _partyMasterProcessor.GetAll(),
                ItemMasters = _itemMasterProcessor.GetAll()
            };

            if (id != null)
            {
                var data = _poMasterProcessor.GetByID(id.Value);

                modelVM.PODetailsList = _poDetailsProcessor.GetByPOID(id.Value);

                foreach (var item in modelVM.PODetailsList)
                {
                    item.ItemMaster = _itemMasterProcessor.GetByID(item.ItemID);
                }

                modelVM.PurchaseOrder = data;
            }

            return View(modelVM);
        }

        [HttpPost, ActionName("Save")]
        [ValidateAntiForgeryToken]
        public ActionResult SavePost(PurchaseOrderViewModel model)
        {
            var modelVM = new PurchaseOrderViewModel
            {
                PartyMasters = _partyMasterProcessor.GetAll(),
                ItemMasters = _itemMasterProcessor.GetAll(),
                PurchaseOrder = model.PurchaseOrder
            };

            //if (ModelState.IsValid)
            {
                if (modelVM.PurchaseOrder.POID != 0)
                {
                    // UPDATE
                    int output = _poMasterProcessor.Edit(modelVM.PurchaseOrder.POID, model.PurchaseOrder);

                    if (output > 0)
                    {
                        SavePODetailsList(modelVM.PurchaseOrder.POID);
                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("", "Purchase Order has not been successfully updated.");
                }
                else
                {
                    // CREATE
                    int output = _poMasterProcessor.Save(model.PurchaseOrder);

                    if (output > 0)
                    {
                        SavePODetailsList(modelVM.PurchaseOrder.POID);
                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("", "Purchase Order has not been successfully created.");
                }
            }

            return View(modelVM);
        }

        private void DeletePODetailsList(int id)
        {
            var PODetailsList = _poDetailsProcessor.GetByPOID(id);
            foreach (var item in PODetailsList)
            {
                _poDetailsProcessor.Delete(item.PODetailsID.Value);
            }
        }

        private void SavePODetailsList(int id = 0)
        {
            if (id != 0)
            {
                DeletePODetailsList(id);
            }

            string listJSON = Request.Form["hfPODetailsList"];
            List<PODetailsModel> poDetailsList = JsonConvert.DeserializeObject<List<PODetailsModel>>(listJSON);

            foreach (var item in poDetailsList)
            {
                item.POID = id;
                _poDetailsProcessor.Save(item);
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var modelVM = new PurchaseOrderViewModel
            {
                PartyMasters = _partyMasterProcessor.GetAll(),
                ItemMasters = _itemMasterProcessor.GetAll(),
                PurchaseOrder = _poMasterProcessor.GetByID(id)
            };

            //if (ModelState.IsValid)
            {
                // DELETE
                int output = _poMasterProcessor.Delete(modelVM.PurchaseOrder.POID);

                if (output > 0)
                {
                    return RedirectToAction(nameof(Index));
                }

                ModelState.AddModelError("", "Purchase Order has not been successfully deleted.");

            }

            return View(modelVM);
        }
    }
}