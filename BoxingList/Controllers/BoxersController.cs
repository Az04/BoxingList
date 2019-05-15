using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxingList.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoxingList.Controllers
{
    public class BoxersController : Controller
    {

        private readonly ApplicationDbContext _db;

        public BoxersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Boxers.ToList());
        }

        //GET Boxer/Create
        public IActionResult Create()
        {
            //Load container for name, division and record
            return View();
        }
    }
}