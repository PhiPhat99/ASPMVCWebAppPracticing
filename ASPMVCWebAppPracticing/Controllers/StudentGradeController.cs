using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ASPMVCWebAppPracticing.Controllers
{
    public class StudentGradeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
