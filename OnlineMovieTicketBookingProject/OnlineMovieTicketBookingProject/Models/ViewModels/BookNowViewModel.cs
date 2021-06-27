using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingProject.Models.ViewModels
{
    
    public class BookNowViewModel
    {
        [Key]
        public string Movie_Name { get; set; }
        public DateTime Movie_Date { get; set; }
        public string seatNo { get; set; }
        public int Amount { get; set; }
        public int MovieID { get; set; }
        

    }
}
