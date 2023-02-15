using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieEntryContext : DbContext
    {
        public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options) //contructor only runs the first time a class runs
        {
            //leave blank for now
        }
        public DbSet<EntryResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb) //seeding the db
        {
            mb.Entity<EntryResponse>().HasData(
                new EntryResponse
                {
                    MovieId = 1,
                    movieTitle = "How To Lose A Guy In Ten Days",
                    Category="Romantic Comedy",
                    Year=2003,
                    directorName="Donald Petrie",
                    Rating="PG-13",
                    Edited=true,
                    lentTo=""
                },
                new EntryResponse
                {
                    MovieId = 2,
                    movieTitle = "The Lego Batman Movie",
                    Category = "Action/Adventure",
                    Year = 2017,
                    directorName = "Chris McKay",
                    Rating = "PG",
                    Edited = true,
                    lentTo = ""
                },
                new EntryResponse
                {
                    MovieId = 3,
                    movieTitle = "It's A Wonderful Life",
                    Category = "Drama/Comedy",
                    Year = 1946,
                    directorName = "Frank Capra",
                    Rating = "PG",
                    Edited = true,
                    lentTo = ""
                }

            );
        }
    }
}
