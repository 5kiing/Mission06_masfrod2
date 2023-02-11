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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovieResponse>().HasData(
                new AddMovieResponse
                {
                    MovieId = 1,
                    Category = "Sports",
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
                    Category = "Action/Adventure",
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
                    Category = "Sci-fi/Adventure",
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
