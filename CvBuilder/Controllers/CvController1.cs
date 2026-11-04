using Microsoft.AspNetCore.Mvc;
using CvBuilder.Models;

namespace CvBuilder.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index() { return View(new CvModel()); }
        [HttpPost]
        public IActionResult Preview(CvModel model) { return View(model); }
    }
}