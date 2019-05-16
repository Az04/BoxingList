using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxingList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        //POST CREATE BOXER
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Boxer boxer)
        {
            if (ModelState.IsValid)
            {
                _db.Add(boxer);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(boxer);
        }

        //GET EDIT BOXER INFO
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boxer = await _db.Boxers.SingleOrDefaultAsync(m => m.Id == id);

            if (boxer == null)
            {
                return NotFound();
            }

            return View(boxer);
        }

        //POST EDIT BOXER INFO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Boxer boxer)
        {
            if (ModelState.IsValid)
            {
                _db.Update(boxer);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boxer);
        }
    }
}