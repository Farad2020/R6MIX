using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using R6MIX.Data;
using R6MIX.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string? search)
        {
            var ops = from op in _context.Operator
                         select op;

            if (!String.IsNullOrEmpty(search))
            {
                ops.Include(m => m.OpSide);
                ops = ops.Where(m=> m.Name.ToLower().Contains(search.ToLower()) || m.OpSide.Name.ToLower().Contains(search.ToLower()));
            }
            return View(await ops.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult DBPanel()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
