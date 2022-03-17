using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P224ProductCategory.DAL;
using P224ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224ProductCategory.Controllers
{
    public class HomeController : Controller
    {
        private readonly AmilMarketDbContext _context;

        public HomeController(AmilMarketDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();

            return View(categories);
        }

        public IActionResult Product(int? id)
        {
            if (id == null) return BadRequest();

            if (!_context.Categories.Any(c => c.Id == id)) return NotFound();

            List<Product> products = _context.Products.Where(p => p.CategoryId == id).ToList();

            return View(products);
        }
    }
}
