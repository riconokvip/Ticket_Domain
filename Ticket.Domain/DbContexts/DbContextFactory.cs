namespace Ticket.Domain.DbContexts
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(Environment.Local);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

    internal static class Environment
    {
        public static string Local = "Server=RICON-ITWEB;Database=Ticket;User ID=tohi_dev;Password=tohi1234;TrustServerCertificate=True;MultipleActiveResultSets=true;";
        public static string Dev = "Server=103.171.92.205,1433;Database=Ticket;User ID=sa;Password=okvip@@123;TrustServerCertificate=True;MultipleActiveResultSets=true;";
    }
}
