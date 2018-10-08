using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInviteWebApplication.Models
{
    public class Guest
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [MaxLength(10)]
        public string Mobile { get; set; }
        [Range(1,4)]
        public int Count { get; set; }
    }
}