using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WillHomeWork1.Models;

namespace WillHomeWork1.Controllers
{
    public class 客戶清單Controller : Controller
    {
        客戶資料Entities db = new 客戶資料Entities();
        // GET: 客戶清單
        public ActionResult Index()
        {
            var data = db.客戶清單.ToList();
            return View(data);
        }
    }
}