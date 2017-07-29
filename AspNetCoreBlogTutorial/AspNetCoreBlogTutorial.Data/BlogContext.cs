using AspNetCoreBlogTutorial.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBlogTutorial.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
