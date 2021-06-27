using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMovieTicketBookingProject.Data;
using OnlineMovieTicketBookingProject.Models;
using OnlineMovieTicketBookingProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingProject.Controllers
{
    public class CartTController : Controller
    {
        private UserManager<ApplicationUser> _usermanager;
        private ApplicationDbContext _context;
        

        public CartTController(ApplicationDbContext context, UserManager<ApplicationUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
        }

        public IActionResult Index()
        {
            var item = _context.Cart.Where(a => a.userId == _usermanager.GetUserId(HttpContext.User)).ToList();
            return View(item);
        }
    }
}
