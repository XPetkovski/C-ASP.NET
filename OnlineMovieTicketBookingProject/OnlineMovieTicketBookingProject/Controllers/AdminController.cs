using FileUploadControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieTicketBookingProject.Data;
using OnlineMovieTicketBookingProject.Models;
using OnlineMovieTicketBookingProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingProject.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private UploadInterface _upload;

        public AdminController(ApplicationDbContext context, UploadInterface upload)
        {
            _upload = upload;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IList<IFormFile> files, MovieDetailViewModel vmodel, MovieDetails movie)
        {
            string path = string.Empty;
            movie.Movie_Name = vmodel.Name;
            movie.Movie_Description = vmodel.Description;
            movie.DatAndTime = vmodel.DateofMovie;
            foreach (var item in files)
            {
                path = Path.GetFileName(item.FileName.Trim());
                movie.MoviePicture = "~/uploads/" + path;
            }
            _upload.uploadfilemultiple(files);
            _context.MovieDetails.Add(movie);
            _context.SaveChanges();
            TempData["Success"] = "Save Your Movie";
            return RedirectToAction("Create", "Admin");
            //return View();
            
        }
        [HttpGet]
        public IActionResult CheckBookSeat()
        {
            var getBookingTable = _context.BookingTable.ToList().OrderByDescending(a => a.Datetopresent);
            return View(getBookingTable);
        }
        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var getUserTable = _context.Users.ToList();
            return View(getUserTable);
        }
    }
}
