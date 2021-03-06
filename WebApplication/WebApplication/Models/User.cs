﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Key { get; set; }

        [MaxLength(127)]
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [MinLength(5)]
        [MaxLength(14)]
        [Required]
        [RegularExpression(@"^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])).+$")]  //Password Validation
        public string Password { get; set; }

    }

}