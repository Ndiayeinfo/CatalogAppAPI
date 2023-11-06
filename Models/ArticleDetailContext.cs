using Microsoft.EntityFrameworkCore;

namespace CatalogAppAPI.Models
{
    public class ArticleDetailContext : DbContext
    {
        public ArticleDetailContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ArticleDetail> ArticleDetails { get; set; }
    }
}
