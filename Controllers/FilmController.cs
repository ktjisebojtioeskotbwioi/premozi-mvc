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
        public string hello(string name="", int  id=1)
        {
            if(name == "")
            {
                return HtmlEncoder.Default.Encode("Hiiii hiiii hellooo");
            }
            else
            {
                return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
            }
        }
    }
}
