using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCAppContext>>()))
            {
                if (context.Movie.Any())
                {
                    context.Movie.AddRange(new Movie {
                        Title = "",
                        RealeseData = DateTime.Parse(""),
                        Genre = "",
                        Price =
                    
                    });
                }
            }
        }

    }
}
