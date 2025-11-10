using ASPMVCWebAppPracticing.Data;
using ASPMVCWebAppPracticing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ASPMVCWebAppPracticing.Controllers
{
    public class StudentGradeController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentGradeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            Students s1 = new Students();   // Standard Object Creation
            s1.Id = 68050808;
            s1.Name = "Alice Lee";
            s1.Score = 88;

            var s2 = new Students();    //Type Interence Objects Creation
            s2.Id = 68050909;
            s2.Name = "Bob Scarletta";
            s2.Score = 50;

            Students s3 = new();    // Target Typed New Expression Object Creation
            s3.Id = 68051001;
            s3.Name = "Charlie Sunday";
            s3.Score = 45;

            List<Students> AllStudentsList = new List<Students>();
            AllStudentsList.Add(s1);
            AllStudentsList.Add(s2);
            AllStudentsList.Add(s3);

            return View(AllStudentsList);

            //return View();
        }

        // Get Method
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Students obj)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
