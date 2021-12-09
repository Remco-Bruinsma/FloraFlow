using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Models
{
    public class User 
    {
        [Required (ErrorMessage = "username is required")]
        public string UserId { get; set; }
        [Required (ErrorMessage ="password is required")]
        public string Password { get; set; }
    }
}
