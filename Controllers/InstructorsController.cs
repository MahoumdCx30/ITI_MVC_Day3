using ITI_MVC_Assingment_D2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI_MVC_Assingment_D2.Controllers
{
    public class InstructorsController : Controller
    {
        ApplicationDbContext _context =new ApplicationDbContext();
        public IActionResult Index()
        {

            var instructors = _context.Instructors.ToList();
            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            var instructor = _context.Instructors.Find(id);
            return View(instructor);
        }
    }
}
