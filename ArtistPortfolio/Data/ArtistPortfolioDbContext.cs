using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtistPortfolio.Data
{
    public class ArtistPortfolioDbContext : IdentityDbContext
    {
        public ArtistPortfolioDbContext(DbContextOptions<ArtistPortfolioDbContext> options)
            : base(options)
        {
        }
    }
}