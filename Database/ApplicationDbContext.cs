using Microsoft.EntityFrameworkCore;

namespace aws_demo.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }
    }
}
