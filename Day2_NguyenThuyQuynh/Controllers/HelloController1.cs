using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2_NguyenThuyQuynh.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] ="Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
