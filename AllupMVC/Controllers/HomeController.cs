using AllupMVC.DAL;
using AllupMVC.Models;
using AllupMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllupMVC.Controllers
{
    public class HomeController:Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
          
         
            HomeVM homeVM = new HomeVM
            {
                Slides = await _context.Slides
                .OrderBy(s => s.Order)
                .ToListAsync(),

                Products = await _context.Products
                .Include(p=>p.ProductImages
                .Where(pi=>pi.IsPrimary!=null))
                .ToListAsync()
            };
            return View(homeVM);
        }
    }
}
