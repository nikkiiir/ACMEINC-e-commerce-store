using ACMEINC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEINC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderHistoryController : Controller
    {
        private ApplicationDbContext _db;

        public OrderHistoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.OrderDetails.ToList());
        }
    }
}
