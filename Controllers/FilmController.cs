using Microsoft.AspNetCore.Mvc;
using premozi.Models;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;

namespace premozi.Controllers
{
    public class FilmController : Controller
    {
        private readonly DataBaseContext _context;
        public FilmController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello(string name="", int  id=1)
        {
            if (name == "")
            {
                ViewData["Message"]= HtmlEncoder.Default.Encode("Hiiii hiiii hellooo");
                return View();
            }
            else
            {
                ViewData["Message"]= HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
                return View();
            }
        }
        public ActionResult Lista()
        {           
            return View(_context.Film);
        }
    }
}
