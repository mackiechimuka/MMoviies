using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-3"),
                    Genre = "Adventure-Drama",
                    Price = 9.99M,
                    Rating = "PG",
                    Image = "17Miracle.png"
                },
                new Movie
                {
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-5-31"),
                    Genre = "Adventure-Drama",
                    Price = 19.99M,
                    Rating = "PG",
                    Image ="Ephram.png"
                },
                new Movie
                {
                    Title = "Gordon B. Hinckley: A Giant Among Men",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Romantic",
                    Price = 3.99M,
                    Rating = "PG",
                    Image = "gordon.png"
                },
                new Movie
                {
                    Title = "Love, Kennedy",
                    ReleaseDate = DateTime.Parse("2017-6-2"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "PG",
                    Image ="Love.png"
                }
            );
            context.SaveChanges();
        }
    }
}
