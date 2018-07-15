namespace TesteTecnofit.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using TesteTecnofit.Data.Contexto;

    internal sealed class Configuration : DbMigrationsConfiguration<TesteTecnofit.Data.Contexto.TesteTecnofitContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TesteTecnofitContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
