using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {

        }
        public DbSet<Movie> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    Category = "Sport/Drama",
                    Title = "Remember the Titans",
                    Year = 2000,
                    Director = "Boaz Yakin",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "One of Conner's Favs"
                },
                new Movie
                {
                    MovieId = 2,
                    Category = "Musical/Drama",
                    Title = "Greatest Showman, The",
                    Year = 2017,
                    Director = "Michael Gracey",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "One of Conner's Favs"
                },
                new Movie
                {
                    MovieId = 3,
                    Category = "Family/Adventure",
                    Title = "Onward",
                    Year = 2000,
                    Director = "Dan Scanlon",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "One of Conner's Favs"
                }
                );
            ;
        }
    }
}
