// Author: Mason Frodsham masfrod2
// Mission 7 Assignment

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
        [Required(ErrorMessage ="Must have a Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Must have a year.")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "Please Enter the Director's first and last name.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Select a rating from the dropdown list.")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        // this prevents a user from entering more than 25 characters
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")] 
        public string Notes { get; set; }

        // Use foreign key of CategoryId to bring category data into movie item.
        [Required(ErrorMessage = "The {0} field cannot be left blank.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
