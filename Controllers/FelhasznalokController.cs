using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient.Memcached;
using premozi.Models;
using System.Data.Entity;
using System.Text;
using System.Security.Cryptography;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MySql.Data.MySqlClient;

namespace premozi.Controllers
{
    public class FelhasznalokController : Controller
    {
        private readonly DataBaseContext _context;
        public FelhasznalokController(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Bejelentkezes()
        {
            return View();
        }
        public async Task<IActionResult> Regisztracio()
        {
            return View();
        }
        string sha512(string s) => Convert.ToBase64String(SHA512.HashData(Encoding.UTF8.GetBytes(s)));
        [HttpPost]
        public async Task<IActionResult> RegHandler(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string username = form["username"].ToString();
                    string password = form["password"].ToString();
                    string email = form["email"].ToString();
                    if (password.Length > 6 && password.Length < 20)
                    {
                        password = sha512(password);
                        Console.WriteLine($"{username}, {password}, {email}");
                        _context.Felhasznalok.Add(new Felhasznalok { username = username, password = password, email = email });
                        _context.SaveChanges();
                        return View("../Home/Index");
                    }
                    else
                    {
                        throw new BadHttpRequestException("bruh");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            return View("Regisztracio");
        }
        [HttpPost]
        public async Task<IActionResult> LoginHandler(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string username = form["username"].ToString();
                    string password = form["password"].ToString();
                    password = sha512(password);
                    if (_context.Felhasznalok.Where(temp => temp.username==username).Count() != 0 && _context.Felhasznalok.Where(temp => temp.password == password).Count() != 0)
                    {
                        Console.WriteLine($"{username}, {password}");
                        return View("../Home/Index");
                    }
                    else
                    {
                        Console.WriteLine("Nem volt ilyen fiók");
                        return View("Bejelentkezes");
                    }
                }                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return View("Bejelentkezes");
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
