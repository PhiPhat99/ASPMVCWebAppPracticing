using ASPMVCWebAppPracticing.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPMVCWebAppPracticing.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }
    }
}
