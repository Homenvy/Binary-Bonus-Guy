using ForexTrading.Models;
using ForexTrading.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForexTrading.Controllers
{
    public class HomeController : Controller
    {
        public ForexTradingDB _db = new ForexTradingDB();

        public ActionResult Index()
        {
            BonusModelsVM vm = new BonusModelsVM();

            if (vm == null)
            {
                return View("Database is Empty.");
            }
            else
            {
                vm.Forex = _db.Forex.ToList();
                vm.Binary = _db.Binary.ToList();
                return View(vm);
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ForexDetail(Forex dbId)
        {
            int Id = dbId.Id;
            Forex _item = new Forex();
            _item = _db.Forex.Find(Id);
            return View(_item);

        }

        public ActionResult BinaryDetail(Binary dbId)
        {
            int Id = dbId.Id;
            Binary _item = new Binary();
            _item = _db.Binary.Find(Id);
            return View(_item);
        }

        public ActionResult CrossRate()
        {
            return View();
        }

        public ActionResult BinaryOption()
        {
            return View();
        }

        public ActionResult ForexTrading()
        {
            return View();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}