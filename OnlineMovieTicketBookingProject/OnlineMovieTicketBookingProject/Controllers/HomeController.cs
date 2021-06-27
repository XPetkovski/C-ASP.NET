using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingProject.Data;
using OnlineMovieTicketBookingProject.Models;
using OnlineMovieTicketBookingProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingProject.Controllers
{
    public class HomeController : Controller
    {
        int count = 1;
        bool flag = true;
        private UserManager<ApplicationUser> _usermanager;
        private ApplicationDbContext _context;
        //private readonly ILogger<HomeController> _logger;
        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
            //_logger = logger;
            
        }
        


        public IActionResult Index()
        {
            var getMovieList = _context.MovieDetails.ToList();
            return View(getMovieList);
        }
        [HttpGet]
        public IActionResult BookNow(int Id)
        {
            BookNowViewModel vm = new BookNowViewModel();
            var item = _context.MovieDetails.Where(a => a.ID == Id).FirstOrDefault();
            vm.Movie_Name = item.Movie_Name;
            vm.Movie_Date = item.DatAndTime;
            vm.MovieID = Id;
            return View(vm);
        }
        [HttpPost]
        public IActionResult BookNow(BookNowViewModel vm)
        {
            List<BookingTable> booking = new List<BookingTable>();
            List<Cart> carts = new List<Cart>();
            string seatno = vm.seatNo.ToString();
            int movieId = vm.MovieID;

            string[] seatnoArray = seatno.Split(',');
            count = seatnoArray.Length;
            if(checkseat(seatno, movieId)==false)
            {
                foreach (var item in seatnoArray)
                {
                    carts.Add(new Cart { Amount=150, MovieId=vm.MovieID, UserId= _usermanager.GetUserId(HttpContext.User), date=vm.Movie_Date, SeatNumber=item});
                }
                foreach (var item in carts)
                {
                    _context.Cart.Add(item);
                    _context.SaveChanges();
                }
                TempData["Success"] = "Seat no. Booked, Check your cart";
            }
            else
            {
                TempData["seatnomsg"] = "Please change your seat number";
            }
            return RedirectToAction("BookNow");
        }

        private bool checkseat(string seatno, int movieId)
        {
            //throw new NotImplementedException();
            string seats = seatno;
            string[] seatreserve = seats.Split(',');
            var seatnolist = _context.BookingTable.Where(a => a.MovieDetailsId == movieId).ToList();
            foreach (var item in seatnolist)
            {
                string alreadybook = item.seatnumber;
                foreach (var item1 in seatreserve)
                {
                    if(item1 == alreadybook)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag == false)
                return true;
            else
                return false;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult checkseat(DateTime Movie_Date, BookNowViewModel booknow)
        {
            string seatno = string.Empty;
            var movielist = _context.BookingTable.Where(a => a.Datetopresent == Movie_Date).ToList();
            if(movielist!=null)
            {
                var getseatno = movielist.Where(b => b.MovieDetailsId == booknow.MovieID).ToList();
                if (getseatno != null)
                {
                    foreach (var item in getseatno)
                    {
                        seatno = seatno + " " + item.seatnumber.ToString();
                    }
                    TempData["SNO"] = "Already Booked" + seatno;
                }
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
