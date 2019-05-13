using Microsoft.EntityFrameworkCore;
using Url_cutter.Models.DataModels;

namespace Url_cutter.Data
{
    public class UrlCutterContextDB : DbContext 
    {
        public UrlCutterContextDB(DbContextOptions<UrlCutterContextDB>options):base(options)
        {
            Database.Migrate();
        }
        
        public DbSet<StoredUrl> StoredUrls { get; set; }
    }
}
