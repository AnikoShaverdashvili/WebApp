using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class IssueDbContext:DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext>options) 
            :base(options)
        { 

        }
        public DbSet<Issue> Issues { get; set; }    
    }
}
