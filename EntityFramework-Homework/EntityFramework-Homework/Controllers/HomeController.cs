
using EntityFramework_Homework.Data;
using EntityFramework_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework_Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}