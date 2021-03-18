namespace LoginDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoginDomain.DataModel.LoginContext>
    {
        public Configuration()
        {
            //Automatic Migration keep off
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoginDomain.DataModel.LoginContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
