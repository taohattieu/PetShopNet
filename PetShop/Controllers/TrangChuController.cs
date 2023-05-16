using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class TrangChuController : Controller
    {
        private PetShopDBContext db = new PetShopDBContext();
        // GET: TrangChu
        public ActionResult Index()
        {
            ViewBag.TaoHatTieuPetShop = db.Products.Count();
            return View();
        }
    }
}