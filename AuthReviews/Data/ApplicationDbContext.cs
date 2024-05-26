using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthReviews.Components.Movies;

namespace AuthReviews.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AuthReviews.Components.Movies.Movie> Movie { get; set; } = default!;
    }
}
