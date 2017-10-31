
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreMvc.Models;

namespace NetCoreMvc.Controllers
{
    public class StudentsController : Controller
    {
       /* private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<ViewResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }*/
    }
}