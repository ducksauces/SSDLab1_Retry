﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSDLab1_Retry.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        
        public DateTime EstablishedDate { get; set; }
    }
}
