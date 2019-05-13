using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Url_cutter.Data;
using Microsoft.Extensions.DependencyModel;

namespace Url_cutter.Migrations
{
    public class Initialize
    {
        //configuration.GetConnectionString("DefaultConnection")

        public static UrlCutterContextDB GetContext(string connection)
        {
            DbContextOptionsBuilder<UrlCutterContextDB> options = new DbContextOptionsBuilder<UrlCutterContextDB>();
            options.UseMySQL(connection);
            return new UrlCutterContextDB(options.Options);
        }
    }
}