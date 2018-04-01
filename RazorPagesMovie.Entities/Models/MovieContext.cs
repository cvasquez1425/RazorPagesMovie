using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesMovie.Entities.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
                    : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
