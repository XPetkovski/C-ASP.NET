using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineMovieTicketBookingProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineMovieTicketBookingProject.Models.ViewModels;

namespace OnlineMovieTicketBookingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<BookingTable> BookingTable { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<MovieDetails> MovieDetails { get; set; }
        public DbSet<OnlineMovieTicketBookingProject.Models.ViewModels.MovieDetailViewModel> MovieDetailViewModel { get; set; }
        public DbSet<OnlineMovieTicketBookingProject.Models.ViewModels.BookNowViewModel> BookNowViewModel { get; set; }
        public DbSet<OnlineMovieTicketBookingProject.Models.ViewModels.ApplicationUser> ApplicationUser { get; set; }
    }
}
