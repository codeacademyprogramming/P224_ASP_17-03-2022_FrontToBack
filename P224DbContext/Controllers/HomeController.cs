using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224DbContext.DAL;
using P224DbContext.Models;
using P224DbContext.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224DbContext.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbContextP224 _context;

        public HomeController(DbContextP224 context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Student> students =  _context.Students.ToList();
            List<Group> groups = _context.Groups.ToList();

           

            List<StudentGroup> studentGroups = _context.StudentGroups
                .Include(s => s.Student)
                .Include(s => s.Group)
                .ToList();

            HomeVM homeVM = new HomeVM
            {
                Students = students,
                Groups = groups,
                StudentGroups = studentGroups
            };

            return View(homeVM);
        }
    }
}
