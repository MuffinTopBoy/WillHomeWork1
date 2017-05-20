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
        public ActionResult Index(string keyword)
        {
            var data = db.客戶清單.Where(x=>x.客戶名稱.Contains(keyword)).ToList();
            ViewData.Model = data;
            return View();
        }
    }
}