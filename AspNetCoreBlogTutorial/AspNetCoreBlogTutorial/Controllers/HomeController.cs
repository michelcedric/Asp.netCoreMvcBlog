using AspNetCoreBlogTutorial.Data;
using AspNetCoreBlogTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreBlogTutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _context;

        public HomeController(BlogContext context)
        {
            _context = context;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            Person person = _context.Persons.Select(p => new Person
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                ID = p.ID
            }).First();

            return View(person);
        }
    }
}
