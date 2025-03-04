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
    public class AccountController : Controller
    {
        private readonly DataBaseContext _context;
        public AccountController(DataBaseContext context)
        {
            _context = context;
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        string sha512(string s) => Convert.ToBase64String(SHA512.HashData(Encoding.UTF8.GetBytes(s)));
        [HttpPost]
        public ActionResult RegHandler(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string _username = form["username"].ToString();
                    string _password = form["password"].ToString();
                    string _email = form["email"].ToString();
                    //validation (sort of)
                    string _errorMessages = "";
                    if(_context.Users.Where(temp => temp.username == _username).Any())
                    {
                        _errorMessages+="Az felhasználónévnek egyedinek kell lennie<br>";
                    }
                    if(_context.Users.Where(temp => temp.email == _email).Any())
                    {
                        _errorMessages += "Az Email címnek egyedinek kell lennie<br>";
                    }
                    if (!(_password.Length > 6 && _password.Length < 30))
                    {
                        _errorMessages += "A jelszónak 6 és 30 karakter között kell lennie<br>";
                    }
                    if(_errorMessages != "")
                    {
                        throw new Exception(_errorMessages);
                    }
                    _password = sha512(_password);
                    User _tUser = new User { username = _username, password = _password, email = _email };
                    _context.Users.Add(_tUser);
                    _context.SaveChanges();
                    Console.WriteLine($"UID: {_tUser.userID}, username: {_tUser.username}, email: {_tUser.email}");
                    return View("../Home/Index");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View("Registration");
        }
        [HttpPost]
        public ActionResult LoginHandler(IFormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string emailOrUserName = form["username"].ToString();
                    string password = form["password"].ToString();
                    password = sha512(password);
                    IEnumerable<User> _tUserEnum = _context.Users.Where(temp => temp.password == password && temp.username == emailOrUserName || temp.email == emailOrUserName);
                    if (_tUserEnum.Any())
                    {
                        User _tUser = _tUserEnum.First();
                        Console.WriteLine($"UID: {_tUser.userID}, username: {_tUser.username}, email: {_tUser.email}");
                        return View("../Home/Index");
                    }
                    else
                    {
                        Console.WriteLine("Helytelen felhasználónév, email, vagy jelszó");
                        return View("Login");
                    }
                }                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return View("Login");
        }

        // GET: FelhasznalokController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult lista()
        {
            return View(_context.Users.ToList());
        }

        // GET: FelhasznalokController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Users
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
