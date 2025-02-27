using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;

namespace premozi.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hello(string name="", int  id=1)
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
    }
}
