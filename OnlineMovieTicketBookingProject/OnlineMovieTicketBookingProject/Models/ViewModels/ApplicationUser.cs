using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineMovieTicketBookingProject.Models.ViewModels
{

    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        
         
        
    }

}
