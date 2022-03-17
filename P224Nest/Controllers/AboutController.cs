using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224Nest.DAL;
using P224Nest.Models;
using P224Nest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Nest.Controllers
{
    public class AboutController : Controller
    {
        private readonly NestDB _context;

        public AboutController(NestDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //About about = _context.Abouts.Include(a=>a.AboutImages).FirstOrDefault();

            //if (about == null) return BadRequest();

            AboutVM aboutVM = new AboutVM
            {
                About = _context.Abouts.Include(a => a.AboutImages).FirstOrDefault(),
                Provides = _context.Provides.ToList()
            };

            return View(aboutVM);
        }
    }
}
