using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dropdown.Models;
using dropdown.Data;
using Microsoft.EntityFrameworkCore;

namespace dropdown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            // var section = new Section{
            //     Name= "A"
            // };

            

            // _context.Sections.Add(section);
            // _context.SaveChanges();

            // var cls = new Class{
            //     Name="One"
            // };

            // _context.Classes.Add(cls);
            // _context.SaveChanges();

            // var std = new Student{
            //     Name = "MM"
            // };

            // _context.Students.Add(std);
            // _context.SaveChanges();

        //     var cls = _context.Classes.FirstOrDefault(x=>x.Id == 4);
        //    //var cls = _context.Classes.FirstOrDefault(x=>x.Id == 2);
        //    //var stds = _context.Students.FirstOrDefault(x=>x.Id == 1);
        //     _context.Classes.Remove(cls);

        //     await _context.SaveChangesAsync();

            //var undeletedClasses = _context.Classes.Where(x=>EF.Property<Char>(x,"RecStatus")=='A').ToList(); //without using global filters


            var undeletedClasses = _context.Classes.ToList();
            return Ok(undeletedClasses);
        }

        public IActionResult Privacy()
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
