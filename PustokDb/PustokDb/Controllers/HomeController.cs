using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PustokDb.DAL;
using PustokDb.Models;
using PustokDb.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PustokDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;


        public HomeController(PustokDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeViewModel viewModel = new HomeViewModel
            {
               
            };
            return View(viewModel);
        }

    }
}
