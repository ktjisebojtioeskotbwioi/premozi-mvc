using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using premozi.Models;
using System.Data.Entity;

namespace premozi.Controllers
{
    public class FelhasznalokController : Controller
    {
        private readonly DataBaseContext _context;
        public FelhasznalokController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: FelhasznalokController
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> lista()
        {
            return View(_context.Felhasznalok.ToList());
        }

        // GET: FelhasznalokController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Felhasznalok
                .FirstOrDefaultAsync(m => m.userID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: FelhasznalokController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FelhasznalokController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FelhasznalokController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FelhasznalokController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FelhasznalokController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FelhasznalokController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
