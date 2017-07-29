using AspNetCoreBlogTutorial.Data.Models;
using System.Linq;

namespace AspNetCoreBlogTutorial.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Persons.Any())
            {
                var person = new Person
                {
                    FirstName = "Cédric",
                    LastName = "Michel"
                };

                context.Persons.Add(person);

                context.SaveChanges();
            }
        }
    }
}
