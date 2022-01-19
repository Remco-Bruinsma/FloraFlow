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
        
        private string userId { get; set; }
       
        private string password { get; set; }
        
        public string UserId { get=> userId; set=> userId = value; }
        
        public string Password { get=> password; set=> password = value; }
    }
}
