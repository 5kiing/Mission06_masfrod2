// Author: Mason Frodsham masfrod2
// Mission 7 Assignment

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_masfrod2.Models
{
    public class Category
    {
        // Model items for the Category table. This also has data validation
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The {0} feild cannot be blank.")]
        public string CategoryName { get; set; }
    }
}
