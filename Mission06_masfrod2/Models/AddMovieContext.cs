// Author: Mason Frodsham masfrod2
// Mission 6 Assignment

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_masfrod2.Models
{
    public class AddMovieContext : DbContext
    {
        // constructor
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base (options)
        {
            // left blank
        }

        public DbSet<AddMovieResponse> Responses { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // seeded data

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Horror" },
                new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Sports" },
                new Category { CategoryId = 4, CategoryName = "Sci-Fi/Adventure" },
                new Category { CategoryId = 5, CategoryName = "Thriller" }
            );

            mb.Entity<AddMovieResponse>().HasData(
                new AddMovieResponse
                {
                    MovieId = 1,
                    CategoryId = 3,
                    Title = "Remeber the Titans",
                    Year = 2000,
                    Director = "Boaz Yakin",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Wife",
                    Notes = "Best Movie Ever"
                },
                new AddMovieResponse
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Pirates of the Caribbean",
                    Year = 2003,
                    Director = "Gore Verbinski",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddMovieResponse
                {
                    MovieId = 3,
                    CategoryId = 4,
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
