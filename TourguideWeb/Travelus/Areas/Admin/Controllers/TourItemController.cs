using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelus.Data;
using travelus.Models.ViewModels;

namespace travelus.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
        public TourItemViewModel TourItemVM { get; set; }

        public TourItemController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            TourItemVM = new TourItemViewModel()
            {
                Category = _db.Category,
                TourItem = new Models.TourItem()
            };
        }

        public async Task<IActionResult> Index()
        {
            var tourItems = await _db.TourItem.Include(m=>m.Category).Include(m=>m.SubCategory).ToListAsync();
            return View(tourItems);
        }

        //GET FOR CREATE
        public IActionResult Create()
        {
            return View(TourItemVM);
        }
    }
}
