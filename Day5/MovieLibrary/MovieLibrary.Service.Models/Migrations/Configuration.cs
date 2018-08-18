namespace MovieLibrary.Service.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieLibrary.Service.Models.MoiveDbContext>
    {
        public Configuration()
        {
            
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MovieLibrary.Service.Models.MoiveDbContext";
        }

        protected override void Seed(MovieLibrary.Service.Models.MoiveDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            for (int i = 1; i < 11; i++)
            {
                context.Movies.AddOrUpdate(
                    new Movie
                    {
                        Id = i,
                        Title = $"Movie {i}",
                        ReleasedDate = DateTime.Now,
                        Status = true
                    });
            }
        }
    }
}
