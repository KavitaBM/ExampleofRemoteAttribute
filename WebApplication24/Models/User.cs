using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication24.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [Remote("CheckUsername", "User", ErrorMessage ="This Username exists already")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Country")]
        public int CountryId { get; set; }


        public string Email { get; set; }
        public string Phone { get; set; }
    }
}