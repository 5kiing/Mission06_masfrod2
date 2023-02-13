// Author: Mason Frodsham masfrod2
// Mission 6 Assignment

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_masfrod2.Models
{
    // model for movie addition to database 
    public class AddMovieResponse
    {
        [Key] // here are data validation fields
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        // this prevents a user from entering more than 25 characters
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")] 
        public string Notes { get; set; }
    }
}
