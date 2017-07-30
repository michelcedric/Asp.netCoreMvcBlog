using AspNetCoreBlogTutorial.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace AspNetCoreBlogTutorial.Data
{
    public class BlogContext : DbContext
    {

        #region Entity Framework Migration

        public BlogContext() : this(new DbContextOptionsBuilder<BlogContext>()
          .UseSqlServer(GetConfig().GetConnectionString("DefaultConnection"))
          .Options)
        {

        }

        private static IConfiguration GetConfig()
        {
            var projectDirectory = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));

            IConfigurationBuilder builder = new ConfigurationBuilder()
               .SetBasePath(projectDirectory)
               .AddJsonFile("appsettings.json");

            return builder.Build();
        }

        #endregion

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
       
    }

}
